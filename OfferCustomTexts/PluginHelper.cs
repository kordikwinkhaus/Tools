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
            get { return "Reporty - vlastní úvodní a závěrečné texty"; }
        }

        public Form CreateWindow(string connString)
        {
            return new MainForm(connString);
        }
    }
}
