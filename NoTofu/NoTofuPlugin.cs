using System.ComponentModel.Composition;
using NoTofu.Properties;
using Tools;

namespace NoTofu
{
    [Export(typeof(IToolsPlugin))]
    public class NoTofuPlugin : IToolsPlugin
    {
        public string Name
        {
            get { return Resources.NoTofuPlugin; }
        }

        public void Run(string connString)
        {
            var form = new NoTofuProgressDialog(connString);
            form.ShowDialog();
        }
    }
}
