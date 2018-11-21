using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class CountryEditor : Form
    {
        string country;

        
        public CountryEditor()
        {
            InitializeComponent();
        }

        public CountryEditor(string c)
        {
            country = c;
            InitializeComponent();
        }


        private void AddCountry_Load(object sender, EventArgs e)
        {
            SetCountryData();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCountryData();
                MessageBox.Show("Changes Saved!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please, enter correct data");
            }
        }


        private void SetCountryData()
        {
            LanguagesList.DataSource = SQLEditor.GetList("SELECT LanguageName FROM Language");
            CurrencyList.DataSource = SQLEditor.GetCurList("SELECT CurrencyName FROM Currency");
            ContList.SelectedIndex = 3;
            CapitalList.DataSource = SQLEditor.GetCurList("SELECT City.CityName FROM City, Region WHERE City.RegionId = Region.RegionId AND Region.CountryName='" + country + "'");
            LanguagesList.ClearSelected();

            if (country != null)
            {
                DataTable dt = SQLEditor.DoSqlOperation(String.Format("SELECT * FROM Country WHERE CountryName = '{0}'", country));

                label8.Text = country;

                NameField.Text = dt.Rows[0].ItemArray[0].ToString();
                AreaField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[1]);
                PopulationField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[2]);
                GovernmentField.Text = dt.Rows[0].ItemArray[3].ToString();
                GDPField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[4]);
                LeaderField.Text = dt.Rows[0].ItemArray[5].ToString();
                CapitalList.Text = City.SearchCityById(dt.Rows[0].ItemArray[6].ToString());
                ContList.Text = dt.Rows[0].ItemArray[7].ToString();
                CurrencyList.Text = dt.Rows[0].ItemArray[8].ToString();

                List<string> list = Country.GetContryLangs(country);

                for (int i = 0; i < list.Count; i++)
                {
                    LanguagesList.SetSelected(LanguagesList.Items.IndexOf(list[i]), true);
                }
            }
        }

        private void SaveCountryData()
        {
            string name = NameField.Text;
            int area = Convert.ToInt32(AreaField.Value);
            long pop = Convert.ToInt64(PopulationField.Value);
            string gov = GovernmentField.Text;
            string cap = "NULL";
            double gdp = (float)GDPField.Value;
            string leader = LeaderField.Text;
            string cur = "'" + CurrencyList.Text + "'";

            if (CapitalList.Text != "Nope")
                cap = City.SearchCityByName(CapitalList.Text, country);


            if (cur == "'Nope'")
                cur = "NULL";


            if (name == "" || gov == "" || area <= 0)
                throw new Exception();


            List<string> langs = new List<string>();

            if (LanguagesList.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < LanguagesList.SelectedIndices.Count; i++)
                {
                    langs.Add(LanguagesList.Items[LanguagesList.SelectedIndices[i]].ToString());
                }
            }


            if (country != null)
            {
                Country.UpdateCountry(country, name, area, pop.ToString(), gov, gdp, leader, cap, ContList.Text, cur);

                if (langs.Count > 0)
                    Country.UpdateContryLangs(country, name, langs);
            }
            else
            {
                Country.InsertCountry(name, area, pop.ToString(), gov, gdp, leader, cap, ContList.Text, cur);

                if (langs.Count > 0)
                    Country.SetContryLangs(name, langs);
            }
        }
    }
}
