using System.Windows;
using OfferOptTexts;
using UserExtensions;

namespace UserExt
{
    public class ExtensionsFactory : IExtensionsFactory
    {
        public FrameworkElement GetPropertyPage(EPropPage pg, string connection, string lang)
        {
            switch (pg)
            {
                case EPropPage.pDokument:
                    return new DocumentPage(connection);
            }

            return null;
        }
    }
}
