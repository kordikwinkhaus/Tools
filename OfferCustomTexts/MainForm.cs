using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

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

            colLangID.DataSource = langs;
            colLangID.DisplayMember = "Name";
            colLangID.ValueMember = "LangID";

            // načtení kolekce uživatelských textů
            _textsVM = new List<CustomTextViewModel>();
            var customTexts = _repository.GetTexts();
            foreach (var customText in customTexts)
            {
                _textsVM.Add(new CustomTextViewModel(customText));
            }

            // nabindování do gridu
            BindAllTexts();
        }

        private void BindAllTexts()
        {
            SimpleSortableBindingList<CustomTextViewModel> sortableList = new SimpleSortableBindingList<CustomTextViewModel>(_textsVM);
            dgvTexts.DataSource = sortableList;
        }

        private void cmdClearFilter_Click(object sender, EventArgs e)
        {
            BindAllTexts();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            var frm = new CustomTextEditor(_repository);
            frm.CustomText = new CustomText { is_header = true };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _repository.CreateCustomText(frm.CustomText);
            }
        }

        private void cmdApplyFilter_Click(object sender, EventArgs e)
        {
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

            if (!rbAllTexts.Checked)
            {
                bool isHeader = rbHeaderTexts.Checked;
                texts = texts.Where(t => t.IsHeader == isHeader);
            }

            SimpleSortableBindingList<CustomTextViewModel> sortableList = new SimpleSortableBindingList<CustomTextViewModel>(texts);
            dgvTexts.DataSource = sortableList;
        }
    }
}
