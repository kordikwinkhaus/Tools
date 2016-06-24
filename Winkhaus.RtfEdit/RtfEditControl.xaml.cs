using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.Win32;

namespace Winkhaus.RtfEdit
{
    public partial class RtfEditControl : UserControl
    {
        private readonly RtfEditViewModel _viewmodel;

        public RtfEditControl()
        {
            InitializeComponent();
            this.DataContext = _viewmodel = new RtfEditViewModel();
        }

        public string Rtf
        {
            get
            {
                TextRange tr = new TextRange(rtfTextBox.Document.ContentStart, rtfTextBox.Document.ContentEnd);
                using (MemoryStream ms = new MemoryStream())
                {
                    tr.Save(ms, DataFormats.Rtf);
                    string rtf = ASCIIEncoding.Default.GetString(ms.ToArray());
                    return RtfHelper.Sanitize(rtf);
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    using (MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(value)))
                    {
                        rtfTextBox.Selection.Load(stream, DataFormats.Rtf);
                        var pos = rtfTextBox.Document.ContentStart;
                        rtfTextBox.Selection.Select(pos, pos);
                    }
                }
                else
                {
                    rtfTextBox.FontFamily = _viewmodel.FontFamilies[0].FontFamily;
                    rtfTextBox.FontSize = _viewmodel.FontSizes[2].Size;
                    rtfTextBox.Foreground = _viewmodel.Colors[0].Brush;
                }
                SetToolbarBySelection();
            }
        }

        public void FocusRtfTextBox()
        {
            rtfTextBox.Focus();
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

        private void cmbFontSize_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (_viewmodel.SelectedFontSize != null)
            {
                rtfTextBox.Selection.SetFontSize(_viewmodel.SelectedFontSize.Size);
            }
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_viewmodel.SelectedFontFamily != null)
            {
                rtfTextBox.Selection.SetFontFamily(_viewmodel.SelectedFontFamily.FontFamily);
            }
        }

        private void cmbFontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_viewmodel.SelectedColor != null)
            {
                rtfTextBox.Selection.SetForeground(_viewmodel.SelectedColor.Brush);
            }
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

                _viewmodel.TrySelectSize(selection.GetFontSize());
                _viewmodel.TrySelectColor(selection.GetForeground());
                _viewmodel.TrySelectFontFamily(selection.GetFontFamily());
            }
            else
            {
                _viewmodel.TrySelectSize(double.NaN);
                _viewmodel.TrySelectColor(null);
                _viewmodel.TrySelectFontFamily(null);
            }
        }

        private void cmdImportRtf_Click(object sender, RoutedEventArgs e)
        {
            OpenRtfText();
        }

        private void cmdExportRtf_Click(object sender, RoutedEventArgs e)
        {
            SaveRtfText();
        }

        private void SaveRtfText()
        {
            SaveFileDialog dialog = DialogFactory.GetSaveRtfDialog();
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllText(dialog.FileName, this.Rtf);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        private void OpenRtfText()
        {
            OpenFileDialog dialog = DialogFactory.GetOpenRtfDialog();
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    var rtf = File.ReadAllText(dialog.FileName);
                    this.Rtf = rtf;
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
