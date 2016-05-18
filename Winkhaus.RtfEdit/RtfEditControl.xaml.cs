using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                    this.rtfTextBox.Selection.Load(stream, DataFormats.Rtf);
                }
            }
        }

        public void FocusRtfTextBox()
        {
            rtfTextBox.Focus();
        }
    }
}
