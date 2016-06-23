namespace OfferCustomTexts
{
    public class CustomText
    {
        public int ID { get; set; }

        public string typ_prof { get; set; }

        public int text_order { get; set; }

        public int lang_ID { get; set; }

        public string report_key { get; set; }

        public string custom_text { get; set; }

        public bool is_header { get; set; }

        public bool keep_together { get; set; }

        public bool pg_break { get; set; }

        public bool last_footer { get; set; }

        public string once_key { get; set; }

        public bool optional { get; set; }

        public string opt_desc { get; set; }

        internal void Fix()
        {
            if (optional)
            {
                lang_ID = 0;
                typ_prof = null;
                once_key = null;
            }
            else
            {
                opt_desc = null;
            }

            if (is_header)
            {
                last_footer = false;
            }
        }
    }
}
