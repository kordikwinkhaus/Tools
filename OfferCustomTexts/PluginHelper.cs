using System.ComponentModel.Composition;
using System.Windows.Forms;
using Tools;

namespace OfferCustomTexts
{
    [Export(typeof(IToolsPlugin))]
    public class PluginHelper : IToolsPlugin
    {
        public string Name
        {
            get { return "TEST"; }
        }

        public Form CreateWindow(string connString)
        {
            return new MainForm();
        }
    }
}
