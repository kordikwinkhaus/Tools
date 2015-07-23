using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Controls;
using System.Xml.Linq;
using UserExtensions;

namespace OfferOptTexts
{
    public partial class DocumentPage : UserControl, IUserForm
    {
        bool _restoring = false;

        public DocumentPage(string connString)
        {
            LoadTexts(connString);
            InitializeComponent();
        }

        private void LoadTexts(string connString)
        {
            this.HeaderTexts = new List<OptText>();
            this.FooterTexts = new List<OptText>();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT ID, opt_desc, is_header FROM dbo.OfferCustomTexts WHERE [optional]=1 ORDER BY text_order, opt_desc", conn))
                using (OleDbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var optText = new OptText(this)
                        {
                            ID = dr.GetInt32(0),
                            Desc = dr.GetString(1)
                        };
                        if (dr.GetBoolean(2))
                        {
                            this.HeaderTexts.Add(optText);
                        }
                        else
                        {
                            this.FooterTexts.Add(optText);
                        }
                    }
                }
            }
        }

        public IList<OptText> HeaderTexts { get; private set; }
        public IList<OptText> FooterTexts { get; private set; }

        private XElement _objectData;
        public XElement ObjectData
        {
            get { return _objectData; }
            set
            {
                _objectData = value;
                _restoring = true;

                _objectData.Headers().RestoreSelection(this.HeaderTexts);
                _objectData.Footers().RestoreSelection(this.FooterTexts);

                _restoring = false;
            }
        }

        public bool SetData(XElement data, int document, int position, int profileType)
        {
            this.ObjectData = data.OptTexts();

            if (this.DataContext != this)
            {
                this.DataContext = this;
            }

            return true;
        }

        public object Title
        {
            get { return "Texty nabídek"; }
        }

        internal void SaveSelection()
        {
            if (_restoring) return;

            _objectData.Headers().SaveSelection(this.HeaderTexts);
            _objectData.Footers().SaveSelection(this.FooterTexts);
        }
    }
}
