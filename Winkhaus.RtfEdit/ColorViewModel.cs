using System.Windows.Media;

namespace Winkhaus.RtfEdit
{
    public class ColorViewModel
    {
        public ColorViewModel(SolidColorBrush brush)
        {
            this.Brush = brush;
        }

        public SolidColorBrush Brush { get; private set; }
    }
}
