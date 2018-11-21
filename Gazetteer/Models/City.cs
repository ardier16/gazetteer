using System;
using System.Collections.Generic;
using System.Data;

namespace Gazetteer
{
    public class City : SQLEditor
    {
        public static void InsertCity(string name, string lon, string lat, int area, string population, int year,
                        string leader, int regId)
        {
            int id = SetId("SELECT CityId FROM City");
            DoSqlOperation(String.Format("INSERT INTO City VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                            id, name, lon, lat, area, population, year, leader, regId));
        }

        public static void UpdateCity(int id, string name, string lon, string lat, int area, string population, int year,
                                string leader, int regId)
        {
            DoSqlOperation(String.Format(@"UPDATE City SET CityName='{0}', CityLongitude='{1}', CityLatitude='{2}', CityArea={3}, 
                                            CityPopulation ='{4}', CityBuildYear={5}, CityLeader='{6}', RegionId='{7}'" +
                                            "WHERE CityId={8}", name, lon, lat, area, population, year, leader, regId, id));
        }

        public static void DeleteCity(string name, int regId)
        {
            DoSqlOperation("DELETE FROM City WHERE CityId=" + GetCityId(regId, name));
        }


        public static string SearchCityByName(string name, string country)
        {
            DataTable dt = DoSqlOperation(@"SELECT City.CityId FROM City, Region WHERE City.RegionId=Region.RegionId AND 
                                        City.CityName='" + name + "' AND Region.CountryName='" + country + "'");

            return dt.Rows[0].ItemArray[0].ToString();
        }

        public static string SearchCityById(string id)
        {
            if (id == "")
                return "Nope";
            return DoSqlOperation("SELECT CityName FROM City WHERE CityId=" + id).Rows[0].ItemArray[0].ToString();
        }

        public static int GetCityId(int rId, string name)
        {
            DataTable dt = DoSqlOperation(String.Format("SELECT CityId FROM City WHERE RegionId='{0}' AND CityName='{1}'", 
                                                        rId, name));

            return Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
        }

        public static List<List<string>> CityStat(string query)
        {
            List<List<string>> list = new List<List<string>>();
            DataTable dt = DoSqlOperation(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i].ItemArray[0].ToString() + ", " + dt.Rows[i].ItemArray[1].ToString();
                string value = dt.Rows[i].ItemArray[2].ToString();
                list.Add(new List<string>());
                list[i].AddRange(new string[] { name, value });
            }

            return list;
        }

        // Returns the city longitude in an array {degrees, minutes, seconds}
        public static int[] GetLongitude(string cLong)
        {
            int[] lon = new int[4];

            string d = cLong.Split('°')[0];
            string m = cLong.Split('°')[1].Split('\'')[0];
            string s = cLong.Split('°')[1].Split('\'')[1].Split('\"')[0];

            lon[0] = int.Parse(d);
            lon[1] = int.Parse(m);
            lon[2] = int.Parse(s);

            if (cLong.Contains("E"))
                lon[3] = 1;
            else
                lon[3] = 0;

            return lon;
        }

        // Returns the city latitude in an array {degrees, minutes, seconds}
        public static int[] GetLatitude(string cLat)
        {
            int[] lat = new int[4];

            string d = cLat.Split('°')[0];
            string m = cLat.Split('°')[1].Split('\'')[0];
            string s = cLat.Split('°')[1].Split('\'')[1].Split('\"')[0];

            lat[0] = int.Parse(d);
            lat[1] = int.Parse(m);
            lat[2] = int.Parse(s);

            if (cLat.Contains("N"))
                lat[3] = 1;
            else
                lat[3] = 0;

            return lat;
        }

        public static List<string> GetCityByIndex(string id)
        {
            List<string> list = new List<string>();

            DataTable dt = DoSqlOperation(@"SELECT City.CityName, City.CityLongitude, City.CityLatitude, Region.RegionType, Region.RegionName, 
                                            Region.CountryName FROM City, Region WHERE Region.RegionId=City.RegionId AND CityId=" + id);

            list.Add(dt.Rows[0].ItemArray[0].ToString());
            list.Add(dt.Rows[0].ItemArray[1].ToString());
            list.Add(dt.Rows[0].ItemArray[2].ToString());
            list.Add(dt.Rows[0].ItemArray[3].ToString());
            list.Add(dt.Rows[0].ItemArray[4].ToString());
            list.Add(dt.Rows[0].ItemArray[5].ToString());

            return list;
        }

        public static DataTable GetCities()
        {
            DataTable dt = DoSqlOperation(@"SELECT City.CityId, City.CityName, Region.RegionType, Region.RegionName, 
                                          Region.CountryName FROM City, Region WHERE Region.RegionId=City.RegionId");

            return dt;
        }

        public static List<string> GetCitiesIdcs()
        {
            DataTable dt = GetCities();
            List<string> idcs = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                idcs.Add(dt.Rows[i].ItemArray[0].ToString());
            }

            return idcs;
        }

    }
}
