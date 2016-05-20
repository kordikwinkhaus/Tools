using System.Windows.Media;

namespace Winkhaus.RtfEdit
{
    public class FontFamilyViewModel
    {
        internal FontFamilyViewModel(FontFamily fontFamily)
        {
            this.FontFamily = fontFamily;
            this.FontName = fontFamily.ToString();
        }

        public string FontName { get; private set; }

        public FontFamily FontFamily { get; private set; }
    }
}
