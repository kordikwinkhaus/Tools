using System;

namespace OfferCustomTexts
{
    public class CustomText
    {
        public int ID { get; set; }

        public string typ_prof { get; set; }

        public int text_order { get; set; }

        public int lang_ID { get; set; }

        public string custom_text { get; set; }

        public bool is_header { get; set; }
    }
}
