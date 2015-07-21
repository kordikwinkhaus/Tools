using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OfferCustomTexts.Properties;

namespace OfferCustomTexts
{
    public partial class CustomTextEditor : Form
    {
        private readonly Repository _repository;
        private static string DEFAULT = Resources.ForAllProfiles;
        private readonly IList<Language> _languages;

        public CustomTextEditor(Repository repository)
        {
            InitializeComponent();

            _repository = repository;

            cmbTypProfilu.Items.Add(DEFAULT);
            foreach (var profil in _repository.GetProfileTypes())
            {
                cmbTypProfilu.Items.Add(profil);
            }

            _languages = _repository.GetLanguages();
            cmbLanguages.DataSource = _languages;
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

            if (customText.lang_ID != 0)
            {
                var currentLang = _languages.SingleOrDefault(l => l.LangID == customText.lang_ID);
                if (currentLang != null)
                {
                    cmbLanguages.SelectedItem = currentLang;
                }
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
                chkLastFooter.Checked = customText.last_footer;
            }
            chkKeepTogether.Checked = customText.keep_together;
            chkPageBreak.Checked = customText.pg_break;

            rbKoncovyText_CheckedChanged(null, null);

            txtOnceKey.Text = customText.once_key;
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

            Language lang = (Language)cmbLanguages.SelectedItem;
            _customText.lang_ID = lang.LangID;

            _customText.custom_text = rtfCustomText.Rtf;
            _customText.text_order = Convert.ToInt32(nudPoradi.Value);
            _customText.is_header = rbUvodniText.Checked;
            if (!_customText.is_header)
            {
                _customText.last_footer = chkLastFooter.Checked;
            }
            else
            {
                _customText.last_footer = false;
            }
            _customText.keep_together = chkKeepTogether.Checked;
            _customText.pg_break = chkPageBreak.Checked;

            _customText.once_key = txtOnceKey.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void rbKoncovyText_CheckedChanged(object sender, EventArgs e)
        {
            chkLastFooter.Enabled = rbKoncovyText.Checked;
        }
    }
}
