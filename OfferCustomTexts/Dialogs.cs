using System.Windows.Forms;

namespace OfferCustomTexts
{
    internal static class Dialogs
    {
        internal static SaveFileDialog GetSaveXmlDialog()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = Properties.Resources.ExportXml;
            dlg.ValidateNames = true;
            dlg.CheckPathExists = true;
            dlg.Filter = Properties.Resources.XmlFiles + " (*.xml)|*.xml";
            dlg.OverwritePrompt = true;

            return dlg;
        }

        internal static OpenFileDialog GetOpenXmlDialog()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = Properties.Resources.ImportXml;
            dlg.ValidateNames = true;
            dlg.CheckFileExists = true;
            dlg.Filter = Properties.Resources.XmlFiles + " (*.xml)|*.xml";

            return dlg;
        }
    }
}
