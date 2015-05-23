using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Winkhaus.RtfEditor
{
	internal class FontSelector : BaseSelector
	{
        private FontFamily[] _families;

        internal FontSelector(ToolStripComboBox toolStripCombo)
            : base(toolStripCombo)
        {
            string[] standardFonts = new string[]
			{
				"arial",
				"arial black",
				"calibri",
				"cambria",
				"century gothic",
				"courier",
				"courier new",
				"consolas",
				"fixedsys",
				"helvetica",
				"garamond",
				"impact",
				"sans serif",
				"terminal",
				"tahoma",
				"times new roman",
				"trebuchet ms",
				"verdana"
			};

            _families = new InstalledFontCollection().Families
                            .Where(ff => IsStandardFont(ff, standardFonts))
                            .OrderBy(ff => ff.Name)
                            .ToArray();

            _combo.Items.AddRange(_families);
        }

        protected override void InitInnerCombo(ComboBox cmb)
        {
            base.InitInnerCombo(cmb);

            cmb.DrawMode = DrawMode.OwnerDrawFixed;
            cmb.DrawItem += new DrawItemEventHandler(cmb_DrawItem);
        }

        private void cmb_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index != -1)
            {
                var rect = new Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height - 1);

                using (Font f = new Font(_families[e.Index], 9))
                {
                    e.Graphics.DrawString(_families[e.Index].Name, f, Brushes.Black, rect);
                }

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.DrawFocusRectangle();
                }
            }
        }

        private static bool IsStandardFont(FontFamily family, string[] standardFonts)
        {
            return standardFonts.Contains(family.Name.ToLower());
        }

        internal FontFamily GetDefaultFontFamily()
        {
            return _families[0];
        }

        internal FontFamily GetSelectedFontFamily()
        {
            if (_combo.SelectedIndex != -1)
            {
                return _families[_combo.SelectedIndex];
            }
            else
            {
                return GetDefaultFontFamily();
            }
        }

        internal void TrySelectFontFamily(FontFamily family)
        {
            TrySelectFontFamily((family != null) ? family.Name : null);
        }

        internal void TrySelectFontFamily(string fontName)
        {
            if (!string.IsNullOrEmpty(fontName))
            {
                for (int i = 0; i < _families.Length; i++)
                {
                    if (_families[i].Name == fontName)
                    {
                        _combo.SelectedIndex = i;
                        return;
                    }
                }
            }

            _combo.SelectedIndex = -1;
        }
    }
}
