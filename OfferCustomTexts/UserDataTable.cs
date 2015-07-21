using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace OfferCustomTexts
{
    internal class UserDataTable
    {
        private readonly SqlDataAdapter _adapter;
        private readonly DataSet _set;
        private readonly DataTable _table;
        private readonly SqlCommandBuilder _cmdBuilder;

        internal UserDataTable(SqlDataAdapter dataAdapter, DataSet dataSet)
        {
            _adapter = dataAdapter;
            _set = dataSet;
            _table = dataSet.Tables[0];
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

        internal void WriteXml(Stream stream)
        {
            _table.WriteXml(stream, XmlWriteMode.WriteSchema);
        }

        DataSet _newSet;
        internal IList<DataColumn> ReadXmlAndStartMerge(Stream stream)
        {
            ClearNewDataset();

            _newSet = new DataSet();
            _newSet.ReadXml(stream);

            List<DataColumn> newColumns = new List<DataColumn>();

            var newTab = _newSet.Tables[_table.TableName];

            foreach (DataColumn column in newTab.Columns)
            {
                if (!_table.Columns.Contains(column.ColumnName))
                {
                    newColumns.Add(column);
                }
            }

            return newColumns;
        }

        internal void CancelMerge()
        {
            ClearNewDataset();
        }

        internal void CommitMerge(bool addNewColumns)
        {
            _set.Merge(_newSet, true, (addNewColumns) ? MissingSchemaAction.Add : MissingSchemaAction.Ignore);
            ClearNewDataset();
        }

        private void ClearNewDataset()
        {
            if (_newSet != null)
            {
                _newSet.Dispose();
                _newSet = null;
            }
        }
    }
}
