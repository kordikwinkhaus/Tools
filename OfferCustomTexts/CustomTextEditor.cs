using System;
using System.Windows.Forms;
using OfferCustomTexts.Properties;

namespace OfferCustomTexts
{
    public partial class CustomTextEditor : Form
    {
        private readonly Repository _repository;
        private static string DEFAULT = Resources.ForAllProfiles;

        public CustomTextEditor(Repository repository)
        {
            InitializeComponent();

            _repository = repository;

            cmbTypProfilu.Items.Add(DEFAULT);
            foreach (var profil in _repository.GetProfileTypes())
            {
                cmbTypProfilu.Items.Add(profil);
            }
        }

        private CustomText _customText;
        public CustomText CustomText 
        {
            get { return _customText; }
            set
            {
                _customText = value;
                InitControls(_customText);
            }
        }

        private void InitControls(CustomText customText)
        {
            if (string.IsNullOrEmpty(customText.typ_prof))
            {
                cmbTypProfilu.SelectedIndex = 0;
            }
            else
            {
                cmbTypProfilu.SelectedItem = customText.typ_prof;
            }

            rtfCustomText.Rtf = customText.custom_text;
            nudPoradi.Value = customText.text_order;
            if (customText.is_header)
            {
                rbUvodniText.Checked = true;
            }
            else
            {
                rbKoncovyText.Checked = true;
            }

            // TODO: lang id
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (cmbTypProfilu.SelectedIndex == 0)
            {
                _customText.typ_prof = null;
            }
            else
            {
                _customText.typ_prof = (string)cmbTypProfilu.SelectedItem;
            }

            _customText.custom_text = rtfCustomText.Rtf;
            _customText.text_order = Convert.ToInt32(nudPoradi.Value);
            _customText.is_header = rbUvodniText.Checked;
            // TODO: lang id

            this.DialogResult = DialogResult.OK;
        }
    }
}
