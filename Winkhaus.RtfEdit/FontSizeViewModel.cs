namespace Winkhaus.RtfEdit
{
    public class FontSizeViewModel
    {
        public FontSizeViewModel(int size)
        {
            this.Size = 96 / 72.0 * size;
            this.DisplaySize = size.ToString();
        }

        public double Size { get; private set; }

        public string DisplaySize { get; private set; }
    }
}
