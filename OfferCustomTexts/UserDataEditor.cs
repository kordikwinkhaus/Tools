using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        private void cmdExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = Properties.Resources.ExportXml;
                dlg.ValidateNames = true;
                dlg.CheckPathExists = true;
                dlg.Filter = Properties.Resources.XmlFiles + " (*.xml)|*.xml";
                dlg.OverwritePrompt = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportCore(dlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportCore(string fileName)
        {
            using (FileStream file = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _userData.WriteXml(file);
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = Properties.Resources.ImportXml;
                dlg.ValidateNames = true;
                dlg.CheckFileExists = true;
                dlg.Filter = Properties.Resources.XmlFiles + " (*.xml)|*.xml";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImportCore(dlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ImportCore(string fileName)
        {
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
                var newColumns = _userData.ReadXmlAndStartMerge(file);
                if (newColumns.Count != 0)
                {
                    var result = MessageBox.Show(Properties.Resources.HasNewColumns, this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            CreateColumns(newColumns);
                            LoadData();
                            file.Position = 0;
                            _userData.ReadXmlAndStartMerge(file);
                            _userData.CommitMerge(true);
                            break;

                        case DialogResult.No:
                            _userData.CommitMerge(false);
                            break;

                        default:
                            _userData.CancelMerge();
                            break;
                    }
                }
                else
                {
                    _userData.CommitMerge(true);
                }
            }
        }

        private void CreateColumns(IList<DataColumn> newColumns)
        {
            foreach (var column in newColumns)
            {
                if (column.DataType == typeof(string))
                {
                    try
                    {
                        _repository.AddUserDataColumn(column.ColumnName, column.MaxLength);
                    }
                    catch { }
                }
            }
        }
    }
}
