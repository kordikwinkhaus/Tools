using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoTofu.Properties;

namespace NoTofu
{
    public partial class NoTofuProgressDialog : Form
    {
        private string _connString;

        public NoTofuProgressDialog(string connString)
        {
            InitializeComponent();

            _connString = connString;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            cmdStart.Visible = false;

            try
            {
                ShowProgressUI();
                FixTofu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ShowProgressUI()
        {
            lblSearching.Visible = true;
            pbSearching.Visible = true;
            lblFixing.Visible = true;
            pbFixing.Visible = true;
        }

        private void FixTofu()
        {
            var searching = new Progress<int>(i => pbSearching.Value = i);
            var fixing = new Progress<int>(i => pbFixing.Value = i);

            var fixer = new TofuFixer(searching, fixing);

            Task.Factory.StartNew(() =>
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    fixer.Fix(conn);
                }
            }).ContinueWith(t =>
            {
                if (t.IsCompleted)
                {
                    MessageBox.Show(Resources.SuccessfullyFinished, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    var firstEx = t.Exception.Flatten().InnerExceptions.First();
                    MessageBox.Show(firstEx.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
