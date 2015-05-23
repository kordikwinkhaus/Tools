using System.Drawing;
using System.Windows.Forms;

namespace Winkhaus.Whokna.OutputManager.RTFControl
{
	internal class ColorSelector : BaseSelector
	{
        private SolidBrush[] _palette;

        internal ColorSelector(ToolStripComboBox toolStripCombo)
            :  base(toolStripCombo)
        {
            _palette = new SolidBrush[11];
            _palette[0] = (SolidBrush)Brushes.Black;
            _palette[1] = (SolidBrush)Brushes.Gray;
            _palette[2] = (SolidBrush)Brushes.DarkRed;
            _palette[3] = (SolidBrush)Brushes.Red;
            _palette[4] = (SolidBrush)Brushes.Orange;
            _palette[5] = (SolidBrush)Brushes.Yellow;
            _palette[6] = (SolidBrush)Brushes.YellowGreen;
            _palette[7] = (SolidBrush)Brushes.DarkGreen;
            _palette[8] = (SolidBrush)Brushes.RoyalBlue;
            _palette[9] = (SolidBrush)Brushes.Blue;
            _palette[10] = (SolidBrush)Brushes.Indigo;

            _combo.Items.AddRange(_palette);
        }

        protected override void InitInnerCombo(ComboBox cmb)
        {
            base.InitInnerCombo(cmb);

            cmb.DrawMode = DrawMode.OwnerDrawFixed;
            cmb.DrawItem += new DrawItemEventHandler(cmb_DrawItem);
        }

        private void cmb_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            e.DrawBackground();
            
            if (e.Index != -1)
            {
                Rectangle rect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 4, e.Bounds.Height - 4);
                e.Graphics.FillRectangle(Brushes.Black, rect);

                rect.Inflate(-1, -1);

                e.Graphics.FillRectangle(_palette[e.Index], rect);

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.DrawFocusRectangle();
                }
            }
        }

        internal Color GetDefaultColor()
        {
            return Color.Black;
        }

        internal Color GetSelectedColor()
        {
            if (_combo.SelectedIndex != -1)
            {
                return _palette[_combo.SelectedIndex].Color;
            }
            else
            {
                return GetDefaultColor();
            }
        }

        internal void TrySelectColor(Color color)
        {
            if (!color.IsEmpty)
            {
                for (int i = 0; i < _palette.Length; i++)
                {
                    if (_palette[i].Color == color)
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
