
namespace OfferCustomTexts
{
    public class Language
    {
        public static Language NullLanguage = new Language();

        private readonly string _toString;

        private Language()
        {
            _toString = string.Empty;
        }

        public Language(int langID, string name, string alias)
        {
            this.LangID = langID;
            this.Name = name;
            this.Alias = alias;
            _toString = this.Name + " (" + this.Alias + ")";
        }

        public int LangID { get; private set; }
        public string Name { get; private set; }
        public string Alias { get; private set; }

        public override string ToString()
        {
            return _toString;
        }
    }
}
