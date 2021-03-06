﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfferCustomTexts.Properties;

namespace OfferCustomTexts
{
    public partial class MainForm : Form
    {
        private readonly Repository _repository;
        private List<CustomTextViewModel> _textsVM;

        public MainForm(string connString)
        {
            InitializeComponent();
            dgvTexts.AutoGenerateColumns = false;

            _repository = new Repository(connString);

            // inicializace profilů
            var profiles = _repository.GetProfileTypes();
            cmbProfileType.Items.Add(string.Empty);
            foreach (var profile in profiles)
            {
                cmbProfileType.Items.Add(profile);
            }

            // inicializace jazyků
            var langs = _repository.GetLanguages();
            langs.Insert(0, Language.NullLanguage);
            cmbLanguage.DataSource = langs;

            colLangID.DataSource = _repository.GetLanguages();
            colLangID.DisplayMember = "Name";
            colLangID.ValueMember = "LangID";

            // inicializace klíčů reportů
            var reportKeys = _repository.GetReportKeys();
            cmbReportKeys.Items.Add(string.Empty);
            foreach (var reportKey in reportKeys)
            {
                cmbReportKeys.Items.Add(reportKey);
            }

            LoadData();
        }

        private void LoadData()
        {
            // načtení kolekce uživatelských textů
            _textsVM = new List<CustomTextViewModel>();
            var customTexts = _repository.GetTexts();
            foreach (var customText in customTexts)
            {
                var customTextVM = new CustomTextViewModel(customText);
                _textsVM.Add(customTextVM);
                CalculateCustomText(customTextVM);
            }

            // nabindování do gridu
            BindAllTexts();
        }

        private void CalculateCustomText(CustomTextViewModel viewmodel)
        {
            var vm = viewmodel;
            if (viewmodel.CustomRtfText.Length > 2500)
            {
                vm.CustomText = Properties.Resources.ParsingText;
                Task.Factory.StartNew(() => CalculateCustomTextCore(vm));
            }
            else
            {
                CalculateCustomTextCore(vm);
            }
        }

        private void CalculateCustomTextCore(CustomTextViewModel viewmodel)
        {
            string rawText = RichTextStripper.StripRichTextFormat(viewmodel.CustomRtfText);
            if (InvokeRequired)
            {
                Invoke(new Action(() => 
                {
                    viewmodel.CustomText = rawText;
                    dgvTexts.Invalidate();
                }));
            }
            else
            {
                viewmodel.CustomText = rawText;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (dgvTexts.SortedColumn == null)
            {
                dgvTexts.Sort(colTextOrder, ListSortDirection.Ascending);
            }
        }

        #region Filtering

        private void BindAllTexts()
        {
            SimpleSortableBindingList<CustomTextViewModel> sortableList = new SimpleSortableBindingList<CustomTextViewModel>(_textsVM);
            bsTexts.DataSource = sortableList;
        }

        private void cmdClearFilter_Click(object sender, EventArgs e)
        {
            var sortInfo = GetSortInfo(dgvTexts);

            BindAllTexts();

            TrySetSortInfo(dgvTexts, sortInfo);
        }

        private void cmdApplyFilter_Click(object sender, EventArgs e)
        {
            var sortInfo = GetSortInfo(dgvTexts);

            IEnumerable<CustomTextViewModel> texts = _textsVM;

            if (cmbProfileType.SelectedIndex > 0)
            {
                string typProf = (string)cmbProfileType.SelectedItem;
                texts = texts.Where(t => t.TypProf == typProf || string.IsNullOrEmpty(t.TypProf));
            }

            if (cmbLanguage.SelectedIndex > 0)
            {
                Language lang = (Language)cmbLanguage.SelectedItem;
                texts = texts.Where(t => t.LangID == lang.LangID);
            }

            if (cmbReportKeys.SelectedIndex > 0)
            {
                string reportKey = (string)cmbReportKeys.SelectedItem;
                texts = texts.Where(t => t.ReportKey == reportKey);
            }

            if (!rbAllTexts.Checked)
            {
                bool isHeader = rbHeaderTexts.Checked;
                texts = texts.Where(t => t.IsHeader == isHeader);
            }

            if (chkAutoTexts.Checked)
            {
                texts = texts.Where(t => t.Optional == false);
            }
            if (chkOptTexts.Checked)
            {
                texts = texts.Where(t => t.Optional == true);
            }

            SimpleSortableBindingList<CustomTextViewModel> sortableList = new SimpleSortableBindingList<CustomTextViewModel>(texts);
            bsTexts.DataSource = sortableList;

            TrySetSortInfo(dgvTexts, sortInfo);
        }

        private SortInfo GetSortInfo(DataGridView grid)
        {
            return new SortInfo
            {
                Column = grid.SortedColumn,
                Order = grid.SortOrder
            };
        }

        private void TrySetSortInfo(DataGridView grid, SortInfo sortInfo)
        {
            if (sortInfo != null && sortInfo.Column != null && sortInfo.Order != SortOrder.None)
            {
                grid.Sort(dgvTexts.Columns[sortInfo.Column.Index],
                    (sortInfo.Order == SortOrder.Ascending) ? ListSortDirection.Ascending : ListSortDirection.Descending);
            }
        }

        private class SortInfo
        {
            internal DataGridViewColumn Column;
            internal SortOrder Order;
        }

        #endregion

        #region Editing custom texts

        private void cmdNew_Click(object sender, EventArgs e)
        {
            var frm = new CustomTextEditor(_repository);
            frm.CustomText = new CustomText { is_header = true };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sorting = GetSortInfo(dgvTexts);

                _repository.CreateCustomText(frm.CustomText);
                var vm = new CustomTextViewModel(frm.CustomText);

                CalculateCustomText(vm);

                bsTexts.Add(vm);
                bsTexts.ResetBindings(false);

                TrySetSortInfo(dgvTexts, sorting);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (dgvTexts.SelectedRows.Count == 0) return;

            int index = dgvTexts.SelectedRows[0].Index;
            EditText(index);
        }

        private void dgvTexts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == -1) return;

            EditText(e.RowIndex);
        }

        private void EditText(int index)
        {
            CustomTextViewModel vm = (CustomTextViewModel)bsTexts[index];

            var frm = new CustomTextEditor(_repository);
            frm.CustomText = vm.Model;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sorting = GetSortInfo(dgvTexts);

                _repository.UpdateCustomText(frm.CustomText);
                bsTexts.ResetBindings(false);

                CalculateCustomText(vm);

                TrySetSortInfo(dgvTexts, sorting);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (dgvTexts.SelectedRows.Count == 0) return;

            if (MessageBox.Show(Resources.ReallyDeleteText, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorting = GetSortInfo(dgvTexts);

                int index = dgvTexts.SelectedRows[0].Index;
                CustomTextViewModel vm = (CustomTextViewModel)bsTexts[index];

                _repository.DeleteCustomText(vm.Model);

                _textsVM.Remove(vm);
                bsTexts.RemoveAt(index);
                bsTexts.ResetBindings(false);

                TrySetSortInfo(dgvTexts, sorting);
            }
        }

        #endregion

        private void cmdExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = Dialogs.GetSaveXmlDialog())
            {
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
            using (FileStream file = new FileStream(fileName, FileMode.Create))
            {
                var userData = _repository.GetCustomTexts();
                userData.WriteXml(file);
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = Dialogs.GetOpenXmlDialog())
            {
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
                var userData = _repository.GetCustomTexts();
                userData.ReadXmlAndStartMerge(file);
                userData.CommitMerge(false);
                userData.Update();
                LoadData();
            }
        }

        private void chkAutoTexts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoTexts.Checked)
            {
                chkOptTexts.Checked = false;
            }
        }

        private void chkOptTexts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOptTexts.Checked)
            {
                chkAutoTexts.Checked = false;
            }
        }
    }
}
