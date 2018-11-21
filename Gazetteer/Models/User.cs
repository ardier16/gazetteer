using System;
using System.Data;

namespace Gazetteer
{
    public class User : SQLEditor
    {
        public static void InsertUser(string login, string pass, string email)
        {
            DoSqlOperation(String.Format("INSERT INTO [User] VALUES('{0}', '{1}', '{2}', {3}, '{4}')", login, pass, email, 0, "No"));
        }

        public static string GetUserData(string login)
        {
            if (login == null)
                return "";
            DataTable dt = DoSqlOperation("SELECT * FROM [User] WHERE UserLogin='" + login + "'");

            return dt.Rows[0].ItemArray[4].ToString();

        }

        public static int GetMaxScore(string login)
        {
            return Convert.ToInt32(DoSqlOperation("SELECT UserMaxScore FROM [User] WHERE UserLogin='" + login + "'").Rows[0].ItemArray[0].ToString());
        }

        public static void UpdateMaxScore(string login, string score)
        {
            DoSqlOperation("UPDATE [User] SET UserMaxScore='" + score + "' WHERE UserLogin='" + login + "'");
        }

        public static void UpdateAdmin(string adm, string login)
        {
            DoSqlOperation("UPDATE [User] SET UserIsAdmin='" + adm + "' WHERE UserLogin='" + login + "'");
        }
    }
}
