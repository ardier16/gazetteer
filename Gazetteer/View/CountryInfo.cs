using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class CountryInfo : Form
    {
        public Country Country;
        public int[] idx;
        public List<Continent> conts;
        public string source;
        public DocumentEditor doc = new DocumentEditor();

        public CountryInfo()
        {
            InitializeComponent();
        }

        public CountryInfo(int[] id, List<Continent> c, string s)
        {
            this.idx = id;
            this.conts = c;
            this.source = s;
            InitializeComponent();
        }



        private void CountryInfo_Load(object sender, EventArgs e)
        {
            SetCountryData();
        }



        private void CountryRegions_DoubleClick(object sender, EventArgs e)
        {

            int regId = CountryRegions.SelectedIndices[0];

            var cities = new Cities(conts, idx, regId, source);
            cities.ShowDialog();
            
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
            Country = conts[idx[0]].Countries[idx[1]]; 

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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RegionEditor(conts, idx, source);
            form.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int regId = CountryRegions.SelectedIndices[0];

                var form = new RegionEditor(conts, idx, regId, source);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите регион!", "Внимание!");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int regId = CountryRegions.SelectedIndices[0];
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранный регион?", "Удаление региона", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    doc.DeleteRegion(source, idx[0], idx[1], regId);
                    RefreshList();

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите регион!", "Внимание!");
            }

            
        }

        private void CountryInfo_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            conts = doc.GetData(source);
            CountryRegions.Items.Clear();
            SetCountryData();
        }
    }
}
