using Microsoft.Win32;

namespace Winkhaus.RtfEdit
{
	internal static class DialogFactory
	{
        internal static OpenFileDialog GetOpenRtfDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            SetupRtfFilter(dialog);
            dialog.Multiselect = false;
            dialog.CheckFileExists = true;
            return dialog;
        }

        internal static SaveFileDialog GetSaveRtfDialog()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            SetupRtfFilter(dialog);
            dialog.OverwritePrompt = true;
            return dialog;
        }

        private static void SetupRtfFilter(FileDialog dialog)
        {
            dialog.ValidateNames = true;
            dialog.DefaultExt = "rtf";
            dialog.CheckPathExists = true;
            dialog.Filter = "Rich Text Files|*.rtf";
        }
	}
}
