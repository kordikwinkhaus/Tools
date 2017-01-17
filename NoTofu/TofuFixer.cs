using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NoTofu
{
    internal class TofuFixer
    {
        private readonly IProgress<int> _searching;
        private readonly IProgress<int> _fixing;

        internal TofuFixer(IProgress<int> searching, IProgress<int> fixing)
        {
            _searching = searching;
            _fixing = fixing;
        }

        private int _searchProgress;
        internal int SearchProgress
        {
            get { return _searchProgress; }
            set
            {
                if (value != _searchProgress)
                {
                    _searchProgress = value;
                    if (_searching != null)
                    {
                        _searching.Report(value);
                    }
                }
            }
        }

        private int _fixingProgress;
        internal int FixingProgress
        {
            get { return _fixingProgress; }
            set
            {
                if (value != _fixingProgress)
                {
                    _fixingProgress = value;
                    if (_fixing != null)
                    {
                        _fixing.Report(value);
                    }
                }
            }
        }

        internal void Fix(SqlConnection conn)
        {
            List<LocalizedText> textsToFix = GetTextsToFix(conn);
            FixItems(conn, textsToFix);
        }

        private List<LocalizedText> GetTextsToFix(SqlConnection conn)
        {
            List<LocalizedText> result = new List<LocalizedText>();
            int totalCount = GetTotalCount(conn);
            int processed = 0;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Texts", conn))
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    string text = dr["textValue"].ToString();
                    int id0 = text.IndexOf('\0');
                    if (id0 != -1)
                    {
                        text = text.Substring(0, id0);
                        Guid id = (Guid)dr["id"];
                        short langId = (short)dr["langID"];

                        result.Add(new LocalizedText
                        {
                            Id = id,
                            LangID = langId,
                            Text = text
                        });
                    }

                    this.SearchProgress = ++processed * 100 / totalCount;
                }
            }

            return result;
        }

        private int GetTotalCount(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.Texts", conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void FixItems(SqlConnection conn, List<LocalizedText> textsToFix)
        {
            int totalCount = textsToFix.Count;
            if (totalCount == 0) return;

            int processed = 0;

            using (SqlCommand cmd = new SqlCommand("UPDATE dbo.Texts SET textValue=@t WHERE id=@id AND langID=@lang", conn))
            {
                var txtPar = cmd.Parameters.Add(new SqlParameter("@t", System.Data.SqlDbType.NVarChar));
                var idPar = cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.UniqueIdentifier));
                var langPar = cmd.Parameters.Add(new SqlParameter("@lang", System.Data.SqlDbType.SmallInt));

                foreach (var textToFix in textsToFix)
                {
                    txtPar.Value = textToFix.Text;
                    idPar.Value = textToFix.Id;
                    langPar.Value = textToFix.LangID;

                    cmd.ExecuteNonQuery();

                    this.FixingProgress = ++processed * 100 / totalCount;
                }
            }
        }
    }
}
