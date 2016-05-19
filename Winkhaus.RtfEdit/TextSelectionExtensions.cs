using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Winkhaus.RtfEdit
{
    public static class TextSelectionExtensions
    {
        public static bool IsBold(this TextSelection selection)
        {
            object fwObj = selection.GetPropertyValue(TextElement.FontWeightProperty);
            if (fwObj == DependencyProperty.UnsetValue)
            {
                return false;
            }
            else
            {
                var fontWeight = (FontWeight)fwObj;
                return fontWeight == FontWeights.Bold;
            }
        }

        public static bool IsItalic(this TextSelection selection)
        {
            object fsObj = selection.GetPropertyValue(TextElement.FontStyleProperty);
            if (fsObj == DependencyProperty.UnsetValue)
            {
                return false;
            }
            else
            {
                var fontStyle = (FontStyle)fsObj;
                return fontStyle == FontStyles.Italic;
            }
        }

        public static double GetFontSize(this TextSelection selection)
        {
            object fsObj = selection.GetPropertyValue(TextElement.FontSizeProperty);
            if (fsObj == DependencyProperty.UnsetValue)
            {
                return double.NaN;
            }
            else
            {
                return (double)fsObj;
            }
        }

        public static void SetFontSize(this TextSelection selection, double fontSize)
        {
            selection.ApplyPropertyValue(TextElement.FontSizeProperty, fontSize);
        }

        public static Brush GetForeground(this TextSelection selection)
        {
            object brushObj = selection.GetPropertyValue(TextElement.ForegroundProperty);
            if (brushObj == DependencyProperty.UnsetValue)
            {
                return null;
            }
            else
            {
                return (Brush)brushObj;
            }
        }

        public static void SetForeground(this TextSelection selection, Brush brush)
        {
            selection.ApplyPropertyValue(TextElement.ForegroundProperty, brush);
        }

        #region Underline, Strikethrough

        public static bool IsUnderline(this RichTextBox rtf)
        {
            return CheckTextDecoration(rtf, TextDecorations.Underline[0]);
        }

        public static void SetUnderline(this TextSelection selection, bool underline)
        {
            selection.ApplyPropertyValue(Inline.TextDecorationsProperty, (underline) ? TextDecorations.Underline : new TextDecorationCollection());
        }

        public static bool IsStrikethrough(this RichTextBox rtf)
        {
            return CheckTextDecoration(rtf, TextDecorations.Strikethrough[0]);
        }

        public static void SetStrikethrough(this TextSelection selection, bool strikethrough)
        {
            selection.ApplyPropertyValue(Inline.TextDecorationsProperty, (strikethrough) ? TextDecorations.Strikethrough : new TextDecorationCollection());
        }

        private static bool CheckTextDecoration(RichTextBox rtf, TextDecoration decoration)
        {
            var caret = rtf.CaretPosition;
            Paragraph paragraph = FindBlock<Paragraph>(rtf.Document.Blocks, caret);
            if (paragraph != null)
            {
                Inline inline = paragraph.Inlines.FirstOrDefault(x => x.ContentStart.CompareTo(caret) <= 0 && x.ContentEnd.CompareTo(caret) >= 0) as Inline;
                if (inline != null)
                {
                    TextDecorationCollection decorations = inline.TextDecorations;
                    if (decorations == DependencyProperty.UnsetValue)
                    {
                        return false;
                    }
                    else
                    {
                        return decorations != null && decorations.Contains(decoration);
                    }
                }
            }

            return false;
        }

        private static T FindBlock<T>(BlockCollection blocks, TextPointer position) where T : Block
        {
            T result = null;
            Block block = blocks.FirstOrDefault(x => x.ContentStart.CompareTo(position) == -1 && x.ContentEnd.CompareTo(position) == 1);
            if (block is T)
            {
                result = (T)block;
            }
            else if (block is Table)
            {
                Table table = (Table)block;
                foreach (TableRowGroup rowGroup in table.RowGroups)
                {
                    foreach (TableRow row in rowGroup.Rows)
                    {
                        foreach (TableCell cell in row.Cells)
                        {
                            result = FindBlock<T>(cell.Blocks, position);
                            if (result != null)
                            {
                                return result;
                            }
                        }
                    }
                }
            }

            return result;
        }

        #endregion
    }
}
