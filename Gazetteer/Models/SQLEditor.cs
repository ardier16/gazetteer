using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Gazetteer
{
    public class SQLEditor
    {
        static string ConnectionString =  @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + 
                                         @"\Gazetteer.mdf;Integrated Security=True";

        public static DataTable DoSqlOperation(string query)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                sqlconn.Close();

                return dt;
            }
            catch
            {
                return null;
            }

        }

        public static List<string> GetList(string query)
        {
            DataTable dt = DoSqlOperation(query);
            List<string> list = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i].ItemArray[0].ToString());
            }

            return list;
        }

        public static List<string> GetCurList(string query)
        {
            List<string> cur = new List<string>();
            cur.Add("Nope");
            cur.AddRange(GetList(query));
            return cur;
        }

        public static int SetId(string query)
        {
            List<int> idcs = GetIdList(query);
            idcs.Sort();

            for (int i = 1; i < Int32.MaxValue; i++)
            {
                if (i > idcs.Count)
                    return i;

                if (i == Convert.ToInt32(idcs[i - 1]))
                    continue;
                else
                {
                    return i;
                }
            }

            return 0;
        }

        public static List<int> GetIdList(string query)
        {
            DataTable dt = DoSqlOperation(query);
            List<int> list = new List<int>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString()));
            }

            return list;
        }

    }

}
