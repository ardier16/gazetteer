using System;
using System.Data;

namespace Gazetteer
{
    public class State : SQLEditor
    {
        public static void InsertRegion(string name, int area, string population, string type, string center,
                              string leader, string country)
        {
            int id = SetId("SELECT RegionId FROM Region");
            DoSqlOperation(String.Format("INSERT INTO Region VALUES({0}, '{1}', {2}, {3}, '{4}', {5}, '{6}', '{7}')",
                                            id, name, area, population, type, center, leader, country));
        }

        public static void UpdateRegion(int id, string name, int area, string population, string type, string center,
                                string leader, string country)
        {
            DoSqlOperation(String.Format("UPDATE Region SET RegionName='{0}', RegionArea={1}, RegionPopulation ='{2}', " +
                                            "RegionType='{3}', RegionCenter={4}, RegionLeader='{5}', CountryName='{6}'" +
                                            "WHERE RegionId='{7}'",
                                            name, area, population, type, center, leader, country, id));
        }

        public static void DeleteRegion(string name, string country)
        {
            DoSqlOperation("DELETE FROM City WHERE RegionId=" + GetRegionId(name, country));
            DoSqlOperation("DELETE FROM Region WHERE RegionId=" + GetRegionId(name, country));
        }

        public static int GetRegionId(string name, string country)
        {
            DataTable dt = DoSqlOperation(String.Format(@"SELECT RegionId FROM Region WHERE RegionName='{0}' AND 
                                                        CountryName='{1}'", name, country));

            return Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
        }
    }
}
