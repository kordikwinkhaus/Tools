namespace Winkhaus.RtfEdit
{
    internal static class RtfHelper
    {
        internal static string Sanitize(string rtf)
        {
            return rtf.Replace(@"\*\shppict", "");
        }
    }
}
