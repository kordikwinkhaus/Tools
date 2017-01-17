using System;

namespace NoTofu
{
    internal class LocalizedText
    {
        internal Guid Id { get; set; }
        internal short LangID { get; set; }
        internal string Text { get; set; }
    }
}
