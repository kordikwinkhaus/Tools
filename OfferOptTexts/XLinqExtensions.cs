using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OfferOptTexts
{
    public static class XLinqExtensions
    {
        public static XElement OptTexts(this XElement data)
        {
            XElement optTexts = data.Element("opttext");
            if (optTexts == null)
            {
                optTexts = new XElement("opttext");
                data.Add(optTexts);
            }
            return optTexts;
        }

        public static XElement Headers(this XElement opttext)
        {
            var elem = opttext.Element("headers");
            if (elem == null)
            {
                elem = new XElement("headers");
                opttext.Add(elem);
            }
            return elem;
        }

        public static XElement Footers(this XElement opttext)
        {
            var elem = opttext.Element("footers");
            if (elem == null)
            {
                elem = new XElement("footers");
                opttext.Add(elem);
            }
            return elem;
        }

        public static void SaveSelection(this XElement elem, IList<OptText> texts)
        {
            elem.RemoveAll();

            foreach (var text in texts.Where(t => t.IsSelected))
            {
                elem.Add(new XElement("t", text.ID));
            }
        }

        public static void RestoreSelection(this XElement elem, IList<OptText> texts)
        {
            foreach (var text in texts)
            {
                text.IsSelected = false;
            }

            foreach (var subelem in elem.Descendants("t"))
            {
                int id;
                if (int.TryParse(subelem.Value, out id))
                {
                    foreach (var text in texts)
                    {
                        if (text.ID == id)
                        {
                            text.IsSelected = true;
                        }
                    }
                }
            }
        }
    }
}
