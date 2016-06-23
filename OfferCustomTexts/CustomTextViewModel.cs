using OfferCustomTexts.Properties;

namespace OfferCustomTexts
{
    public class CustomTextViewModel
    {
        private readonly CustomText _model;

        public CustomTextViewModel(CustomText model)
        {
            _model = model;
        }

        public CustomText Model
        {
            get { return _model; }
        }

        public string TypProf 
        {
            get { return _model.typ_prof; }
        }

        public int TextOrder
        {
            get { return _model.text_order; }
        }

        public int LangID 
        {
            get { return _model.lang_ID; }
        }

        public string ReportKey
        {
            get
            {
                if (string.IsNullOrEmpty(_model.report_key))
                {
                    return Resources.ForAllReports;
                }
                else
                {
                    return _model.report_key;
                }
            }
        }

        internal string CustomRtfText
        {
            get { return _model.custom_text; }
        }

        public string CustomText { get; set; }

        public bool IsHeader
        {
            get { return _model.is_header; }
        }

        public bool KeepTogether
        {
            get { return _model.keep_together; }
        }

        public bool PageBreak
        {
            get { return _model.pg_break; }
        }

        public bool LastFooter
        {
            get { return _model.last_footer; }
        }

        public string OnceKey
        {
            get { return _model.once_key; }
        }

        public string OptDesc 
        {
            get { return _model.opt_desc; }
        }

        public bool Optional 
        {
            get { return _model.optional; }
        }
    }
}
