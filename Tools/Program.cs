using System;
using System.ComponentModel.Composition.Hosting;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tools
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string connString = null;
            if (args.Length != 0)
            {
                connString = args[0];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            try
            {
                catalog.Catalogs.Add(new DirectoryCatalog(".\\ToolsPlugins"));
            }
            catch (DirectoryNotFoundException) { /* ok */ }

            var container = new CompositionContainer(catalog);

            var mainWindow = new MainWindow(connString, container);
            Application.Run(mainWindow);
        }

        internal static Icon GetIcon()
        {
            IntPtr hInstance = GetModuleHandle(null);
            IntPtr hIcon = LoadIcon(hInstance, new IntPtr(32512));
            if (hIcon == IntPtr.Zero)
            {
                return null;
            }
            else
            {
                return Icon.FromHandle(hIcon);
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr iconName);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetModuleHandle(string moduleName);
    }
}
