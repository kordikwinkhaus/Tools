using System.Collections.Generic;

namespace OfferOptTexts
{
    public class OptTextGroup
    {
        public OptTextGroup(string groupName)
        {
            this.GroupName = groupName;
        }

        public string GroupName { get; private set; }

        public IList<OptText> Texts { get; set; } = new List<OptText>();
    }
}
