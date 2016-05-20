using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Winkhaus.RtfEdit
{
    public class RtfEditViewModel : INotifyPropertyChanged
    {
        public RtfEditViewModel()
        {
            InitFontSizes();
            InitFontFamilies();
            InitFontColors();
        }

        private void InitFontSizes()
        {
            int[] sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 28, 36, 48, 72 };
            this.FontSizes = new List<FontSizeViewModel>();
            for (int i = 0; i < sizes.Length; i++)
            {
                this.FontSizes.Add(new FontSizeViewModel(sizes[i]));
            }
        }

        private void InitFontFamilies()
        {
            this.FontFamilies = new List<FontFamilyViewModel>();

            string[] standardFonts = new string[]
            {
                "arial",
                "arial black",
                "calibri",
                "cambria",
                "century gothic",
                "courier",
                "courier new",
                "consolas",
                "fixedsys",
                "helvetica",
                "garamond",
                "impact",
                "sans serif",
                "terminal",
                "tahoma",
                "times new roman",
                "trebuchet ms",
                "verdana"
            };

            foreach (var ff in Fonts.SystemFontFamilies
                                    .Where(ff => IsStandardFont(ff, standardFonts))
                                    .OrderBy(ff => ff.ToString()))
            {
                this.FontFamilies.Add(new FontFamilyViewModel(ff));
            }
        }

        private static bool IsStandardFont(FontFamily fontFamily, string[] standardFonts)
        {
            var fn = fontFamily.ToString().ToLower();
            return standardFonts.Contains(fontFamily.ToString().ToLower());
        }

        private void InitFontColors()
        {
            this.Colors = new List<ColorViewModel>();
            this.Colors.Add(new ColorViewModel(Brushes.Black));
            this.Colors.Add(new ColorViewModel(Brushes.DimGray));
            this.Colors.Add(new ColorViewModel(Brushes.Gray));
            this.Colors.Add(new ColorViewModel(Brushes.Silver));
            this.Colors.Add(new ColorViewModel(Brushes.Gainsboro));
            this.Colors.Add(new ColorViewModel(Brushes.SaddleBrown));
            this.Colors.Add(new ColorViewModel(Brushes.DarkRed));
            this.Colors.Add(new ColorViewModel(Brushes.Red));
            this.Colors.Add(new ColorViewModel(Brushes.OrangeRed));
            this.Colors.Add(new ColorViewModel(Brushes.DarkOrange));
            this.Colors.Add(new ColorViewModel(Brushes.Orange));
            this.Colors.Add(new ColorViewModel(Brushes.Gold));
            this.Colors.Add(new ColorViewModel(Brushes.Yellow));
            this.Colors.Add(new ColorViewModel(Brushes.YellowGreen));
            this.Colors.Add(new ColorViewModel(Brushes.Green));
            this.Colors.Add(new ColorViewModel(Brushes.DarkGreen));
            this.Colors.Add(new ColorViewModel(Brushes.RoyalBlue));
            this.Colors.Add(new ColorViewModel(Brushes.Blue));
            this.Colors.Add(new ColorViewModel(Brushes.DarkBlue));
            this.Colors.Add(new ColorViewModel(Brushes.Indigo));
            this.Colors.Add(new ColorViewModel(Brushes.Purple));
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

        public IList<FontFamilyViewModel> FontFamilies { get; private set; }

        private FontFamilyViewModel _selectedFontFamily;
        public FontFamilyViewModel SelectedFontFamily
        {
            get { return _selectedFontFamily; }
            set
            {
                if (_selectedFontFamily != value)
                {
                    _selectedFontFamily = value;
                    OnPropertyChanged(nameof(SelectedFontFamily));
                }
            }
        }

        public IList<ColorViewModel> Colors { get; private set; }

        private ColorViewModel _selectedColor;
        public ColorViewModel SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                if (_selectedColor != value)
                {
                    _selectedColor = value;
                    OnPropertyChanged(nameof(SelectedColor));
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

        internal void TrySelectFontFamily(FontFamily fontFamily)
        {
            if (fontFamily != null)
            {
                string fontName = fontFamily.ToString();
                this.SelectedFontFamily = this.FontFamilies.SingleOrDefault(f => f.FontName == fontName);
            }
            else
            {
                this.SelectedFontFamily = null;
            }
        }

        internal void TrySelectColor(Brush brush)
        {
            SolidColorBrush colorBrush = brush as SolidColorBrush;
            if (colorBrush != null)
            {
                this.SelectedColor = this.Colors.SingleOrDefault(c => c.Brush.Color == colorBrush.Color);
            }
            else
            {
                this.SelectedColor = null;
            }
        }
    }
}
