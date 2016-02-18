using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OfferCustomTexts
{
    public class Repository
    {
        private SqlConnection _conn;

        internal Repository(string connString)
        {
            if (string.IsNullOrEmpty(connString)) throw new ArgumentNullException(nameof(connString));

            _conn = new SqlConnection(connString);

            CreateTablesIfNotExists();
        }

        private void CreateTablesIfNotExists()
        {
            string sql = @"IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OfferCustomTexts]') AND type in (N'U'))
CREATE TABLE dbo.OfferCustomTexts
(
  ID INT NOT NULL PRIMARY KEY,
  typ_prof NVARCHAR(25) NULL,
  text_order INT NOT NULL,
  lang_ID INT NOT NULL,
  custom_text NVARCHAR(MAX) NOT NULL,
  once_key NVARCHAR(20) NULL,
  opt_desc NVARCHAR(25) NULL,
  is_header BIT NOT NULL, 
  keep_together BIT NOT NULL,
  pg_break BIT NOT NULL,
  last_footer BIT NOT NULL,
  optional BIT NOT NULL
)";

            string sql2 = @"IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserCustomData]') AND type in (N'U'))
CREATE TABLE dbo.UserCustomData
(
  Uzivatel NVARCHAR(100) NOT NULL PRIMARY KEY,
  Jmeno NVARCHAR(100) NULL,
  Telefon NVARCHAR(50) NULL,
  Email NVARCHAR(50) NULL
);";

            using (SqlCommand cmd = GetCmd(sql))
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
        }

        private SqlConnection GetDb()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            return _conn;
        }

        private SqlCommand GetCmd(string sql)
        {
            var cmd = new SqlCommand(sql, GetDb());
            return cmd;
        }

        internal IList<string> GetProfileTypes()
        {
            string sql = @"SELECT DISTINCT typ_prof
FROM dbo.typyp
ORDER BY typ_prof";

            List<string> result = new List<string>();

            using (SqlCommand cmd = GetCmd(sql))
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    result.Add(dr.GetString(0));
                }
            }

            return result;
        }

        internal IList<CustomText> GetTexts()
        {
            using (SqlCommand cmd = GetCmd("SELECT * FROM dbo.OfferCustomTexts"))
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                var builder = DynamicBuilder<CustomText>.CreateBuilder(dr);
                return builder.BuildMany(dr);
            }
        }

        internal void CreateCustomText(CustomText customText)
        {
            if (customText.ID == 0)
            {
                using (SqlCommand cmd = GetCmd("SELECT ISNULL(MAX(ID),0)+1 FROM dbo.OfferCustomTexts"))
                {
                    customText.ID = (int)cmd.ExecuteScalar();
                }
            }

            string sql = @"INSERT INTO dbo.OfferCustomTexts (id, typ_prof, text_order, lang_ID, custom_text, is_header, keep_together, pg_break, last_footer, once_key, [optional], opt_desc) 
VALUES (@id, @typ_prof, @text_order, @lang_ID, @custom_text, @is_header, @keep_together, @pg_break, @last_footer, @once_key, @optional, @opt_desc);";

            using (SqlCommand cmd = GetCmd(sql))
            {
                AddCommonParameters(customText, cmd);
                cmd.ExecuteNonQuery();
            }
        }

        private static void AddCommonParameters(CustomText customText, SqlCommand cmd)
        {
            cmd.AddParameterWithValue("@id", customText.ID);
            cmd.AddParameterWithValue("@typ_prof", customText.typ_prof);
            cmd.AddParameterWithValue("@text_order", customText.text_order);
            cmd.AddParameterWithValue("@lang_ID", customText.lang_ID);
            cmd.AddParameterWithValue("@custom_text", customText.custom_text);
            cmd.AddParameterWithValue("@is_header", customText.is_header);
            cmd.AddParameterWithValue("@keep_together", customText.keep_together);
            cmd.AddParameterWithValue("@pg_break", customText.pg_break);
            cmd.AddParameterWithValue("@last_footer", customText.last_footer);
            cmd.AddParameterWithValue("@once_key", customText.once_key);
            cmd.AddParameterWithValue("@optional", customText.optional);
            cmd.AddParameterWithValue("@opt_desc", customText.opt_desc);
        }

        internal void UpdateCustomText(CustomText customText)
        {
            string sql = @"UPDATE dbo.OfferCustomTexts 
SET typ_prof=@typ_prof, text_order=@text_order, lang_ID=@lang_ID, custom_text=@custom_text, is_header=@is_header, keep_together=@keep_together, pg_break=@pg_break, last_footer=@last_footer, once_key=@once_key, [optional]=@optional, opt_desc=@opt_desc
WHERE ID=@id";

            using (SqlCommand cmd = GetCmd(sql))
            {
                AddCommonParameters(customText, cmd);
                cmd.ExecuteNonQuery();
            }
        }

        internal void DeleteCustomText(CustomText customText)
        {
            if (customText.ID == 0) return;

            using (SqlCommand cmd = GetCmd("DELETE FROM dbo.OfferCustomTexts WHERE ID=@id"))
            {
                cmd.AddParameterWithValue("@id", customText.ID);
                cmd.ExecuteNonQuery();                
            }
        }

        internal IList<string> GetUserFields()
        {
            List<string> result = new List<string>();
            string sql = @"SELECT c.COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS c
WHERE c.TABLE_SCHEMA='dbo' AND c.TABLE_NAME='UserCustomData'";

            using (SqlCommand cmd = GetCmd(sql))
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    result.Add(dr.GetString(0));
                }
            }

            return result;
        }

        internal IList<Language> GetLanguages()
        {
            List<Language> result = new List<Language>();

            using (SqlCommand cmd = GetCmd("sp_helplanguage"))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int langID = Convert.ToInt32(dr["langid"]);
                        string name = dr["name"].ToString();
                        string alias = dr["alias"].ToString();

                        result.Add(new Language(langID, name, alias));
                    }
                }
            }

            return result;
        }

        internal UserDataTable GetUserData()
        {
            return GetData("UserCustomData");
        }

        internal UserDataTable GetCustomTexts()
        {
            return GetData("OfferCustomTexts");
        }

        private UserDataTable GetData(string tableName)
        {
            string sql = "SELECT * FROM dbo." + tableName;

            DataSet ds = new DataSet();

            using (SqlCommand cmd = GetCmd(sql))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.FillSchema(ds, SchemaType.Source);
                da.Fill(ds);
                ds.Tables[0].TableName = tableName;

                return new UserDataTable(da, ds);
            }
        }

        internal void AddUserDataColumn(string columName, int maxLength)
        {
            string sql = "ALTER TABLE dbo.UserCustomData ADD [" + columName + "] NVARCHAR(" + maxLength + ")";

            using (SqlCommand cmd = GetCmd(sql))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
