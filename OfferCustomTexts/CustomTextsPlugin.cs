using System.ComponentModel.Composition;
using System.Windows.Forms;
using OfferCustomTexts.Properties;
using Tools;

namespace OfferCustomTexts
{
    [Export(typeof(IToolsPlugin))]
    public class CustomTextsPlugin : IToolsPlugin
    {
        public string Name
        {
            get { return Resources.ReportsCustomTexts; }
        }

        public void Run(string connString)
        {
            var form = new MainForm(connString);
            form.ShowDialog();
        }
    }
}
