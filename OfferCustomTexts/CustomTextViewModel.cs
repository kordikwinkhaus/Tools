
namespace OfferCustomTexts
{
    public class CustomTextViewModel
    {
        private readonly CustomText _model;

        public CustomTextViewModel(CustomText model)
        {
            _model = model;
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

        public string CustomText
        {
            get { return RichTextStripper.StripRichTextFormat(_model.custom_text); }
        }

        public bool IsHeader
        {
            get { return _model.is_header; }
        }
    }
}
