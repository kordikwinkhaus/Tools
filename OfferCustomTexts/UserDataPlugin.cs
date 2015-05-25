using System.ComponentModel.Composition;
using System.Windows.Forms;
using OfferCustomTexts.Properties;
using Tools;

namespace OfferCustomTexts
{
    [Export(typeof(IToolsPlugin))]
    public class UserDataPlugin : IToolsPlugin
    {
        public string Name
        {
            get { return Resources.ReportsUserData; }
        }

        public Form CreateWindow(string connString)
        {
            return new UserDataEditor(connString);
        }
    }
}
