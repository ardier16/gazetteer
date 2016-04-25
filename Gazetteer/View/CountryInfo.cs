using System;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class CountryInfo : Form
    {
        public Country Country;

        public CountryInfo()
        {
            InitializeComponent();
        }

        public CountryInfo(Country country)
        {
            this.Country = country;
            InitializeComponent();
        }



        private void CountryInfo_Load(object sender, EventArgs e)
        {
            SetCountryData();
        }



        private void CountryRegions_DoubleClick(object sender, EventArgs e)
        {
            if (CountryRegions.SelectedIndices.Count == 1)
            {
                Region r = Country.SearchRegionByName(
                    CountryRegions.Items[CountryRegions.SelectedIndices[0]].SubItems[0].Text);

                var cities = new Cities(r.Cities);
                cities.ShowDialog();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        public void SetCountryData()
        {
            CountryName.Text = Country.Name;
            CountryArea.Text = Country.Area.ToString() + " тыс кв км";
            CountryPop.Text = Country.Population.ToString() + " тыс чел";
            CountryUrban.Text = Country.Urbanization + " %";
            CountryGov.Text = Country.Government;
            CountryCap.Text = Country.Capital;

            string langs = "";

            for (int i = 0; i < Country.Languages.Count; i++)
            {
                langs += Country.Languages[i] + "; ";
            }

            CountryLangs.Text = langs.Substring(0, langs.Length - 2);

            for (int i = 0; i < Country.Regions.Count; i++)
            {
                string[] info = new string[] { Country.Regions[i].Name , Country.Regions[i].RegionType,
                    Country.Regions[i].Area.ToString(), Country.Regions[i].Population.ToString(),
                    Country.Regions[i].Urbanization.ToString() + " %", Country.Regions[i].Center };

                ListViewItem list = new ListViewItem(info);
                CountryRegions.Items.AddRange(new ListViewItem[] { list });

            }
        }
    }
}
