﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OfferCustomTexts.Properties;
using Winkhaus.RtfEdit;

namespace OfferCustomTexts
{
    public partial class CustomTextEditor : Form
    {
        private readonly Repository _repository;
        private static string ALL_PROFILES = Resources.ForAllProfiles;
        private static string ALL_REPORTS = Resources.ForAllReports;
        private readonly IList<Language> _languages;
        private readonly RtfEditControl _rtfCustomText;

        public CustomTextEditor(Repository repository)
        {
            InitializeComponent();

            _repository = repository;

            cmbTypProfilu.Items.Add(ALL_PROFILES);
            foreach (var profil in _repository.GetProfileTypes())
            {
                cmbTypProfilu.Items.Add(profil);
            }

            cmbReportKey.Items.Add(ALL_REPORTS);
            foreach (var reportKey in _repository.GetReportKeys())
            {
                cmbReportKey.Items.Add(reportKey);
            }

            _languages = _repository.GetLanguages();
            cmbLanguages.DataSource = _languages;
            rtfEditorHost.Child = _rtfCustomText = new RtfEditControl();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _rtfCustomText.FocusRtfTextBox();
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

            if (string.IsNullOrEmpty(customText.report_key))
            {
                cmbReportKey.Text = ALL_REPORTS;
            }
            else
            {
                cmbReportKey.Text = customText.report_key;
            }

            _rtfCustomText.Rtf = customText.custom_text;
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

            txtOnceKey.Text = customText.once_key;
            txtOptDesc.Text = customText.opt_desc;
            chkOptional.Checked = customText.optional;

            rbKoncovyText_CheckedChanged(null, null);
            chkOptional_CheckedChanged(null, null);
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

            if (cmbReportKey.Text == ALL_REPORTS)
            {
                _customText.report_key = null;
            }
            else
            {
                _customText.report_key = cmbReportKey.Text;
            }

            _customText.custom_text = _rtfCustomText.Rtf;
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
            _customText.opt_desc = txtOptDesc.Text;
            _customText.optional = chkOptional.Checked;

            _customText.Fix();

            this.DialogResult = DialogResult.OK;
        }

        private void rbKoncovyText_CheckedChanged(object sender, EventArgs e)
        {
            chkLastFooter.Enabled = rbKoncovyText.Checked;
        }

        private void chkOptional_CheckedChanged(object sender, EventArgs e)
        {
            txtOptDesc.Enabled = lblOptDesc.Enabled = chkOptional.Checked;
            lblTypProfilu.Enabled = cmbTypProfilu.Enabled =
                lblLanguage.Enabled = cmbLanguages.Enabled =
                lblOnceKey.Enabled = txtOnceKey.Enabled = !chkOptional.Checked;
        }
    }
}
