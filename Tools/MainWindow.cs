using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Windows.Forms;

namespace Tools
{
    public partial class MainWindow : Form
    {
        private readonly string _connString;
        private readonly List<IToolsPlugin> _plugins;

        public MainWindow(string connString, CompositionContainer container)
        {
            InitializeComponent();

            var icon = Program.GetIcon();
            if (icon != null)
            {
                this.Icon = icon;
            }

            if (string.IsNullOrEmpty(connString))
            {
                SqlConnectionForm frm = new SqlConnectionForm();
                frm.Model = new SqlConnectionData();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    connString = frm.Model.ToString();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            else
            {
                connString = Utils.ModifyConnString(connString);
            }

            _connString = connString;
            _plugins = container.GetExports<IToolsPlugin>().Select(l => l.Value).ToList();

            foreach (var plugin in _plugins.OrderBy(p => p.Name))
            {
                lstTools.Items.Add(plugin);
            }
            lstTools.Items.Add("test");
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            TryShowPluginWindow();
        }

        private void lstTools_DoubleClick(object sender, EventArgs e)
        {
            TryShowPluginWindow();
        }

        private void TryShowPluginWindow()
        {
            IToolsPlugin plugin = lstTools.SelectedItem as IToolsPlugin;
            if (plugin != null)
            {
                var window = plugin.CreateWindow(_connString);
                window.ShowDialog(this);
            }
        }
    }
}
