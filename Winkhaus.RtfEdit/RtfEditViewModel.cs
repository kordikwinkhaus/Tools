using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Winkhaus.RtfEdit
{
    public class RtfEditViewModel : INotifyPropertyChanged
    {
        public RtfEditViewModel()
        {
            int[] sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 28, 36, 48, 72 };
            this.FontSizes = new List<FontSizeViewModel>();
            for (int i = 0; i < sizes.Length; i++)
            {
                this.FontSizes.Add(new FontSizeViewModel(sizes[i]));
            }
        }

        public IList<FontSizeViewModel> FontSizes { get; private set; }

        private FontSizeViewModel _selectedFontSize;


        public FontSizeViewModel SelectedFontSize
        {
            get { return _selectedFontSize; }
            set
            {
                if (_selectedFontSize != value)
                {
                    _selectedFontSize = value;
                    OnPropertyChanged(nameof(SelectedFontSize));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void TrySelectSize(double size)
        {
            if (double.IsNaN(size))
            {
                this.SelectedFontSize = null;
            }
            else
            {
                this.SelectedFontSize = this.FontSizes.SingleOrDefault(s => Math.Abs(s.Size - size) < 0.1);
            }
        }
    }
}
