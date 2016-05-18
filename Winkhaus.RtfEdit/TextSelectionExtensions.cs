using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Winkhaus.RtfEdit
{
    public static class TextSelectionExtensions
    {
        #region Bold

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

        public static void SetFontWeight(this TextSelection selection, bool bold)
        {
            selection.ApplyPropertyValue(TextElement.FontWeightProperty, (bold) ? FontWeights.Bold : FontWeights.Normal);
        }

        #endregion

        #region Italic

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

        public static void SetItalic(this TextSelection selection, bool italic)
        {
            selection.ApplyPropertyValue(TextElement.FontStyleProperty, (italic) ? FontStyles.Italic : FontStyles.Normal);
        }

        #endregion

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
            Paragraph paragraph = FindParagraph(rtf.Document.Blocks, caret);
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

        private static Paragraph FindParagraph(BlockCollection blocks, TextPointer position)
        {
            Paragraph paragraph = null;
            Block block = blocks.FirstOrDefault(x => x.ContentStart.CompareTo(position) == -1 && x.ContentEnd.CompareTo(position) == 1);
            if (block is Paragraph)
            {
                paragraph = (Paragraph)block;
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
                            paragraph = FindParagraph(cell.Blocks, position);
                            if (paragraph != null)
                            {
                                return paragraph;
                            }
                        }
                    }
                }
            }

            return paragraph;
        }

        #endregion
    }
}
