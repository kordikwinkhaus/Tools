using System.Data;
using System.Data.SqlClient;

namespace OfferCustomTexts
{
    internal class UserDataTable
    {
        private readonly SqlDataAdapter _adapter;
        private readonly DataTable _table;
        private readonly SqlCommandBuilder _cmdBuilder;

        internal UserDataTable(SqlDataAdapter dataAdapter, DataTable dataTable)
        {
            _adapter = dataAdapter;
            _table = dataTable;
            _cmdBuilder = new SqlCommandBuilder(dataAdapter);
        }

        internal DataTable Table 
        {
            get { return _table; }
        }

        internal void Update()
        {
            _adapter.Update(_table);
        }
    }
}
