using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Winkhaus.RtfEdit
{
    public partial class RtfEditControl : UserControl
    {
        public RtfEditControl()
        {
            InitializeComponent();
        }

        public string Rtf
        {
            get
            {
                TextRange tr = new TextRange(rtfTextBox.Document.ContentStart, rtfTextBox.Document.ContentEnd);
                using (MemoryStream ms = new MemoryStream())
                {
                    tr.Save(ms, DataFormats.Rtf);
                    return ASCIIEncoding.Default.GetString(ms.ToArray());
                }
            }
            set
            {
                using (MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(value)))
                {
                    rtfTextBox.Selection.Load(stream, DataFormats.Rtf);
                    var pos = rtfTextBox.Document.ContentStart;
                    rtfTextBox.Selection.Select(pos, pos);
                }
            }
        }

        public void FocusRtfTextBox()
        {
            rtfTextBox.Focus();
        }

        private void cmdBoldFont_Click(object sender, RoutedEventArgs e)
        {
            rtfTextBox.Selection.SetFontWeight(cmdBoldFont.IsChecked == true);
        }

        private void cmdItalicFont_Click(object sender, RoutedEventArgs e)
        {
            rtfTextBox.Selection.SetItalic(cmdItalicFont.IsChecked == true);
        }

        private void cmdUnderline_Click(object sender, RoutedEventArgs e)
        {
            rtfTextBox.Selection.SetUnderline(cmdUnderline.IsChecked == true);
            SetToolbarBySelection();
        }

        private void cmdStrikethrough_Click(object sender, RoutedEventArgs e)
        {
            rtfTextBox.Selection.SetStrikethrough(cmdStrikethrough.IsChecked == true);
            SetToolbarBySelection();
        }

        private void rtfTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            SetToolbarBySelection();
        }

        private void SetToolbarBySelection()
        {
            var selection = rtfTextBox.Selection;
            if (selection != null)
            {
                cmdBoldFont.IsChecked = selection.IsBold();
                cmdItalicFont.IsChecked = selection.IsItalic();
                cmdUnderline.IsChecked = rtfTextBox.IsUnderline();
                cmdStrikethrough.IsChecked = rtfTextBox.IsStrikethrough();
                
                //tbItalic.Checked = selection.Italic;
                //tbUnderline.Checked = selection.Underline;
                //tbStrikeout.Checked = selection.Strikeout;

                //_sizeSelector.TrySelectSize(Convert.ToInt32(selection.Size));
                //_fontSelector.TrySelectFontFamily(rtfBox.SelectionFont.FontFamily);
            }
            else
            {
                //_sizeSelector.TrySelectSize(-1);
                //_fontSelector.TrySelectFontFamily((string)null);
            }

            //SetButtonAlignmentState(rtfBox.SelectionAlignment);

            //_colorSelector.TrySelectColor(rtfBox.SelectionColor);
        }
    }
}
