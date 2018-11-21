using System;
using System.Collections.Generic;
using System.Data;

namespace Gazetteer
{
    public class Country : SQLEditor
    {
        public static void InsertCountry(string name, int area, string population, string gov, double gdp,
                               string leader, string capital, string continent, string currency)
        {
            DoSqlOperation(String.Format("INSERT INTO Country VALUES('{0}', {1}, {2}, '{3}', {4}, '{5}', {6}, '{7}', {8})",
                                            name, area, population, gov, gdp, leader, capital, continent, currency));
        }

        public static void UpdateCountry(string country, string name, int area, string population, string gov, double gdp,
                                string leader, string capital, string continent, string currency)
        {
            DoSqlOperation("UPDATE Region SET CountryName=NULL WHERE CountryName='" + country + "'");
            DoSqlOperation(String.Format("UPDATE Country SET CountryName='{0}', CountryArea={1}, CountryPopulation ={2}, " +
                                            "CountryGovernment='{3}', CountryGDP={4}, CountryLeader='{5}', CountryCapital={6}, " +
                                            "ContinentName='{7}', CurrencyName={8} WHERE CountryName='{9}'",
                                            name, area, population, gov, gdp, leader, capital, continent, currency, country));
            DoSqlOperation("UPDATE Region SET CountryName='" + name + "' WHERE CountryName IS NULL");
        }

        public static void DeleteCountry(string name)
        {
            UpdateContryLangs(name, name, new List<string>());
            DoSqlOperation(String.Format("DELETE FROM City WHERE RegionId IN(SELECT RegionId FROM Region WHERE CountryName='{0}')", name));
            DoSqlOperation(String.Format("DELETE FROM Region WHERE CountryName='{0}'", name));
            DoSqlOperation(String.Format("DELETE FROM Country WHERE CountryName='{0}'", name));
        }


        public static void SetContryLangs(string countryName, List<string> langs)
        {
            for (int i = 0; i < langs.Count; i++)
            {
                DoSqlOperation(String.Format("INSERT INTO CountryLanguage VALUES('{0}', '{1}')", countryName, langs[i]));
            }
        }

        public static void UpdateContryLangs(string oldName, string newName, List<string> langs)
        {
            DoSqlOperation("DELETE FROM CountryLanguage WHERE CountryName='" + oldName + "'");
            SetContryLangs(newName, langs);
        }

        public static List<string> GetContryLangs(string countryName)
        {
            return GetList("SELECT LanguageName FROM CountryLanguage WHERE CountryName='" + countryName + "'");
        }

        public static List<List<string>> CountryStat(string query)
        {
            List<List<string>> list = new List<List<string>>();
            DataTable dt = DoSqlOperation(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i].ItemArray[0].ToString();
                string value = dt.Rows[i].ItemArray[1].ToString();
                list.Add(new List<string>());
                list[i].AddRange(new string[] { name, value });
            }

            return list;
        }
    }
}
