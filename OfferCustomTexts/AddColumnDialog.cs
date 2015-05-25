using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OfferCustomTexts.Properties;

namespace OfferCustomTexts
{
    public partial class AddColumnDialog : Form
    {
        public AddColumnDialog()
        {
            InitializeComponent();
        }

        public string ColumnName { get; set; }

        public int MaxLength { get; set; }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColumnName.Text)) return;
            if (!IsValidColumnName(txtColumnName.Text))
            {
                MessageBox.Show(Resources.ColumnNameIsNotValid, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.ColumnName = txtColumnName.Text;
            this.MaxLength = Convert.ToInt32(nudMaxLen.Value);

            this.DialogResult = DialogResult.OK;
        }

        private bool IsValidColumnName(string name)
        {
            var regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9_]*$");
            return regex.IsMatch(name);
        }
    }
}
