using System.Windows.Forms;

namespace Tools
{
    internal class Settings
    {
        internal Settings()
        {
            this.WindowState = new FormGeometrySaver(Properties.Settings.Default.WindowState);
        }

        internal FormGeometrySaver WindowState { get; set; }

        internal void Save()
        {
            Properties.Settings.Default.WindowState = this.WindowState.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
