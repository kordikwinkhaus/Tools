using System.ComponentModel.Composition;
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

        public void Run(string connString)
        {
            var form = new UserDataEditor(connString);
            form.ShowDialog();
        }
    }
}
