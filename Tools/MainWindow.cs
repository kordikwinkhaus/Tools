using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Tools.Properties;

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

            if (!VerifyPermissions(connString))
            {
                MessageBox.Show(Resources.MissingPermissions, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }

            _connString = connString;
            _plugins = container.GetExports<IToolsPlugin>().Select(l => l.Value).ToList();

            foreach (var plugin in _plugins.OrderBy(p => p.Name))
            {
                lstTools.Items.Add(plugin);
            }
        }

        private bool VerifyPermissions(string connString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sql = @"SELECT 
ISNULL(IS_ROLEMEMBER('AUT_NADZORCA_BAZ'), 0) AS Supervisor,
ISNULL(IS_SRVROLEMEMBER('sysadmin'), 0) AS SysAdmin";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (dr.Read())
                        {
                            bool admin = Convert.ToBoolean(dr["Supervisor"]) || Convert.ToBoolean(dr["SysAdmin"]);
                            return admin;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
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
                try
                {
                    plugin.Run(_connString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
