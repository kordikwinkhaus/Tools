using System;
using System.Windows.Forms;

namespace OfferCustomTexts
{
    public partial class UserDataEditor : Form
    {
        private readonly Repository _repository;
        private UserDataTable _userData;

        public UserDataEditor(string connString)
        {
            InitializeComponent();

            _repository = new Repository(connString);
            LoadData();
        }

        private void LoadData()
        {
            _userData = _repository.GetUserData();
            dgvUserData.DataSource = _userData.Table;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmdSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private bool SaveChanges()
        {
            try
            {
                _userData.Update();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cmdAutoResize_Click(object sender, EventArgs e)
        {
            dgvUserData.AutoResizeColumns();
        }

        private void cmdAddColumn_Click(object sender, EventArgs e)
        {
            AddColumnDialog frm = new AddColumnDialog();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _repository.AddUserDataColumn(frm.ColumnName, frm.MaxLength);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
