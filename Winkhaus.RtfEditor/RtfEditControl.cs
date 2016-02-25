using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winkhaus.RtfEditor
{
    public partial class RtfEditControl : UserControl
	{
        private FontSelector _fontSelector;
        private ColorSelector _colorSelector;
        private SizeSelector _sizeSelector;
        private bool _rtfBoxHadFocus;

		public RtfEditControl()
		{
			InitializeComponent();

            tbBold.Tag = FontStyle.Bold;
            tbItalic.Tag = FontStyle.Italic;
            tbUnderline.Tag = FontStyle.Underline;
            tbStrikeout.Tag = FontStyle.Strikeout;

            _fontSelector = new FontSelector(cmbFont);
            _colorSelector = new ColorSelector(cmbColor);
            _sizeSelector = new SizeSelector(cmbSize);

            SetToolbarFontDefaults();
		}

        public string Rtf
        {
            get { return rtfBox.Rtf; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    SetToolbarFontDefaults();
                    SetSelectionByToolbar();
                }
                else
                {
                    rtfBox.Rtf = value;
                    SetToolbarBySelection();
                }
            }
        }

        public bool RtfTextChanged { get; private set; }

        private bool _showSettingsControls;
        public bool ShowSettingsControls
        {
            get { return _showSettingsControls; }
            set
            {
                _showSettingsControls = value;
                tbSaveDefaults.Visible = value;
                tbRestoreDefaults.Visible = value;
            }
        }

        protected void SetModify(bool state = true)
        {
            this.RtfTextChanged = state;
        }

        private void SetToolbarFontDefaults()
        {
            if (!TryRestoreFontSettings(null))
            {
                _fontSelector.TrySelectFontFamily(_fontSelector.GetDefaultFontFamily());
                _colorSelector.TrySelectColor(_colorSelector.GetDefaultColor());
                _sizeSelector.TrySelectSize(_sizeSelector.GetDefaultSize());

                tbBold.Checked = false;
                tbItalic.Checked = false;
                tbUnderline.Checked = false;
                tbStrikeout.Checked = false;
                SetButtonAlignmentState(HorizontalAlignment.Left);
            }

            rtfBox.Font = new Font(_fontSelector.GetSelectedFontFamily(), _sizeSelector.GetSelectedSize(), GetCurrentFontStyle());
            rtfBox.ForeColor = _colorSelector.GetSelectedColor();
        }

        private void rtfBox_KeyDown(object sender, KeyEventArgs e)
        {
            SetModify();
            if (e.KeyCode == Keys.Return)
            {
                var font = rtfBox.SelectionFont;
                var color = rtfBox.SelectionColor;

                rtfBox.SelectedText = "\r\n";

                rtfBox.SelectionFont = font;
                rtfBox.SelectionColor = color;
                SetToolbarBySelection();

                e.Handled = true;
            }
            else if (e.KeyCode == Keys.A && e.Control)
            {
                rtfBox.SelectionStart = 0;
                rtfBox.SelectionLength = rtfBox.TextLength;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                tbBold.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.U && e.Control)
            {
                tbUnderline.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.I && e.Control)
            {
                tbItalic.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.C && e.Control)
            {
                tbCopy.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.V && e.Control)
            {
                tbPaste.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.X && e.Control)
            {
                tbCut.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
            }
        }

        #region Methods for handling saving, etc...

        private void SaveRtfText()
        {
            using (SaveFileDialog dialog = DialogFactory.GetSaveRtfDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    rtfBox.SaveFile(dialog.FileName);
                }
            }
        }

        private void OpenRtfText()
        {
            using (OpenFileDialog dialog = DialogFactory.GetOpenRtfDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    rtfBox.Clear();
                    rtfBox.LoadFile(dialog.FileName);
                    SetModify();
                }
            }
        }

        private void SetAlignment(HorizontalAlignment alignment)
        {
            rtfBox.SelectionAlignment = alignment;
            SetButtonAlignmentState(rtfBox.SelectionAlignment);
            SetModify();
        }

        private bool TrySetCurrentColor()
        {
            if (_rtfBoxHadFocus)
            {
                SetCurrentColor();
            }

            return _rtfBoxHadFocus;
        }

        private void SetCurrentColor()
        {
            rtfBox.SelectionColor = _colorSelector.GetSelectedColor();
            SetModify();
        }

        private bool TrySetCurrentFont(Func<Font, Font> fontModifier)
        {
            if (_rtfBoxHadFocus)
            {
                SetCurrentFont(fontModifier);
            }

            return _rtfBoxHadFocus;
        }

        private void SetCurrentFont(Func<Font, Font> fontModifier)
        {
            if (rtfBox.SelectionLength != 0)
            {
                // úprava fontu multistyle výběru
                using (RichTextBox rtfTmp = new RichTextBox())
                {
                    rtfTmp.SelectedRtf = rtfBox.SelectedRtf;
                    int start = rtfBox.SelectionStart;
                    int len = rtfBox.SelectionLength;

                    for (int i = 0; i < len; i++)
                    {
                        rtfTmp.Select(i, 1);
                        rtfTmp.SelectionFont = fontModifier(rtfTmp.SelectionFont);
                    }

                    rtfTmp.SelectAll();
                    rtfBox.SelectedRtf = rtfTmp.SelectedRtf;
                    rtfBox.Select(start, len);
                }
            }
            else
            {
                var style = GetCurrentFontStyle();

                var font = new Font(_fontSelector.GetSelectedFontFamily(), _sizeSelector.GetSelectedSize(), style);
                rtfBox.SelectionFont = font;
            }
            SetModify();
        }

        private FontStyle GetCurrentFontStyle()
        {
            var style = FontStyle.Regular;

            if (tbBold.Checked) style |= FontStyle.Bold;
            if (tbItalic.Checked) style |= FontStyle.Italic;
            if (tbUnderline.Checked) style |= FontStyle.Underline;
            if (tbStrikeout.Checked) style |= FontStyle.Strikeout;

            return style;
        }

        private void SetCurrentAlignment()
        {
            if (tbAlignLeft.Checked)
            {
                rtfBox.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (tbAlignCenter.Checked)
            {
                rtfBox.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (tbAlignRight.Checked)
            {
                rtfBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void SetToolbarBySelection()
        {
            var font = rtfBox.SelectionFont;
            if (font != null)
            {
                tbBold.Checked = font.Bold;
                tbItalic.Checked = font.Italic;
                tbUnderline.Checked = font.Underline;
                tbStrikeout.Checked = font.Strikeout;

                _sizeSelector.TrySelectSize(Convert.ToInt32(font.Size));
                _fontSelector.TrySelectFontFamily(rtfBox.SelectionFont.FontFamily);
            }
            else
            {
                _sizeSelector.TrySelectSize(-1);
                _fontSelector.TrySelectFontFamily((string)null);
            }

            SetButtonAlignmentState(rtfBox.SelectionAlignment);

            _colorSelector.TrySelectColor(rtfBox.SelectionColor);
        }

        private void SetSelectionByToolbar()
        {
            SetCurrentColor();
            SetCurrentFont(f => f);
            SetCurrentAlignment();
        }

        private void SetButtonAlignmentState(HorizontalAlignment alignment)
        {
            tbAlignLeft.Checked = alignment == HorizontalAlignment.Left;
            tbAlignCenter.Checked = alignment == HorizontalAlignment.Center;
            tbAlignRight.Checked = alignment == HorizontalAlignment.Right;
        }

        private bool CanSerializeFontSettings()
        {
            if (cmbFont.SelectedIndex == -1) return false;
            if (cmbSize.SelectedIndex == -1) return false;
            if (cmbColor.SelectedIndex == -1) return false;

            return true;
        }

        private string SerializeFontSettings()
        {
            char sep = '|';
            StringBuilder sb = new StringBuilder();

            sb.Append(_fontSelector.GetSelectedFontFamily().Name);
            sb.Append(sep);
            sb.Append(_sizeSelector.GetSelectedSize());
            sb.Append(sep);
            sb.Append(_colorSelector.GetSelectedColor().Name);
            sb.Append(sep);

            if (tbBold.Checked) { sb.Append("B"); }
            if (tbItalic.Checked) { sb.Append("I"); }
            if (tbUnderline.Checked) { sb.Append("U"); }
            if (tbStrikeout.Checked) { sb.Append("S"); }

            sb.Append(sep);

            if (tbAlignLeft.Checked) { sb.Append("L"); }
            else if (tbAlignCenter.Checked) { sb.Append("C"); }
            else if (tbAlignRight.Checked) { sb.Append("R"); }

            return sb.ToString();
        }

        private bool TryRestoreFontSettings(string settings)
        {
            if (string.IsNullOrEmpty(settings)) return false;

            string[] parts = settings.Split('|');

            try
            {
                _fontSelector.TrySelectFontFamily(parts[0]);
                _sizeSelector.TrySelectSize(Convert.ToInt32(parts[1]));
                _colorSelector.TrySelectColor(Color.FromName(parts[2]));

                tbBold.Checked = parts[3].Contains("B");
                tbItalic.Checked = parts[3].Contains("I");
                tbUnderline.Checked = parts[3].Contains("U");
                tbStrikeout.Checked = parts[3].Contains("S");

                if (parts[4] == "L") { SetButtonAlignmentState(HorizontalAlignment.Left); }
                else if (parts[4] == "C") { SetButtonAlignmentState(HorizontalAlignment.Center); }
                else if (parts[4] == "R") { SetButtonAlignmentState(HorizontalAlignment.Right); }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Menu button handlers

        private void tbOpen_Click(object sender, EventArgs e)
        {
            OpenRtfText();
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            SaveRtfText();
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            rtfBox.Cut();
            SetModify();
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            rtfBox.Copy();
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            DataFormats.Format rtfFormat = DataFormats.GetFormat(DataFormats.Rtf);
            if (rtfBox.CanPaste(rtfFormat))
            {
                rtfBox.Paste(rtfFormat);
                SetModify();
            }
        }

        private void tbAlignLeft_Click(object sender, EventArgs e)
        {
            SetAlignment(HorizontalAlignment.Left);
        }

        private void tbAlignCenter_Click(object sender, EventArgs e)
        {
            SetAlignment(HorizontalAlignment.Center);
        }

        private void tbAlignRight_Click(object sender, EventArgs e)
        {
            SetAlignment(HorizontalAlignment.Right);
        }

        private void ChangeFontStyle_Click(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;

            if (TrySetCurrentFont(GetChangeFunc(button)))
            {
                rtfBox.Focus();
            }
        }

        private Func<Font, Font> GetChangeFunc(ToolStripButton button)
        {
            FontStyle style = (FontStyle)button.Tag;

            if (button.Checked)
            {
                return f => new Font(f, f.Style | style);
            }
            else
            {
                return f => new Font(f, f.Style & ~style);
            }
        }

        private void cmbFont_DropDownClosed(object sender, EventArgs e)
        {
            var family = _fontSelector.GetSelectedFontFamily();

            if (TrySetCurrentFont(f => new Font(family, f.Size, f.Style)))
            {
                rtfBox.Focus();
            }
        }

        private void cmbSize_DropDownClosed(object sender, EventArgs e)
        {
            var size = _sizeSelector.GetSelectedSize();

            if (TrySetCurrentFont(f => new Font(f.FontFamily, size, f.Style)))
            {
                rtfBox.Focus();
            }
        }

        private void cmbColor_DropDownClosed(object sender, EventArgs e)
        {
            if (TrySetCurrentColor())
            {
                rtfBox.Focus();
            }
        }

        private void tbSaveDefaults_Click(object sender, EventArgs e)
        {
            if (CanSerializeFontSettings())
            {
                // TODO: externí poskytovatel konfigurace nebo notifikace pomocí události
                //var nastaveni = Nastaveni.Instance();
                //nastaveni.DefaultFont = SerializeFontSettings();
                //nastaveni.Save();
            }
        }

        private void tbRestoreDefaults_Click(object sender, EventArgs e)
        {
            //string settings = Nastaveni.Instance().DefaultFont;
            // TODO: externí poskytovatel konfigurace nebo notifikace pomocí události
            if (TryRestoreFontSettings(null))
            {
                SetSelectionByToolbar();
            }
        }

        #endregion

        private void rtfBox_SelectionChanged(object sender, EventArgs e)
        {
            SetToolbarBySelection();
            tbSaveDefaults.Enabled = CanSerializeFontSettings();
        }

        private void rtfBox_Click(object sender, EventArgs e)
        {
            _rtfBoxHadFocus = true;
        }

        public void FocusRtfTextBox()
        {
            rtfBox.Focus();
        }
    }
}
