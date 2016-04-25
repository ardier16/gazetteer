using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Cities : Form
    {
        public List<City> cities;
        public string SearchInfo;

        public Cities()
        {
            InitializeComponent();
        }

        public Cities(List<City> cs)
        {
            this.cities = cs;
            InitializeComponent();
        }

        public Cities(List<City> cs, string s)
        {
            this.cities = cs;
            this.SearchInfo = s;
            InitializeComponent();
        }



        private void Cities_Load(object sender, EventArgs e)
        {
            SetCitiesData();
        }



        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    OKButton_Click(null, null);
                    this.Close();
                    break;
                case Keys.Enter:
                    OKButton_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        public void SetCitiesData()
        {
            if (SearchInfo == null)
                InfoField.Text = "Города региона";
            else
                SearchingInfo.Text = SearchInfo;


            for (int i = 0; i < cities.Count; i++)
            {
                string[] info = new string[] { cities[i].Name , cities[i].Region, cities[i].Area.ToString(),
                                               cities[i].Population.ToString(), cities[i].Latitude, cities[i].Longitude};

                ListViewItem list = new ListViewItem(info);
                CitiesList.Items.AddRange(new ListViewItem[] { list });
            }
        }

    }
}
