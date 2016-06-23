using System.ComponentModel;

namespace OfferOptTexts
{
    public class OptText : INotifyPropertyChanged
    {
        private readonly DocumentPage _page;

        public OptText(DocumentPage page)
        {
            _page = page;
        }

        public int ID { get; set; }
        public string Desc { get; set; }
        public string Report { get; set; }

        private bool _isSelected;
        public bool IsSelected 
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    OnPropertyChanged("IsSelected");
                    _page.SaveSelection();
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
