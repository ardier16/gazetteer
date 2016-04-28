using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Cities : Form
    {
        public List<Continent> conts;
        public List<City> cities;
        public string SearchInfo;
        public string source;
        public int[] idx;
        public DocumentEditor doc = new DocumentEditor();

        public Cities()
        {
            InitializeComponent();
        }

        public Cities(List<Continent> c, int[] id, int rid, string s)
        {
            this.conts = c;
            this.idx = new int[] { id[0], id[1], rid };
            this.source = s;
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
            menuStrip1.Visible = false;
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
            {
                InfoField.Text = "Города региона";
                cities = conts[idx[0]].Countries[idx[1]].Regions[idx[2]].Cities;
                menuStrip1.Visible = true;
            }
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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CityEditor(conts, idx, source);
            form.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cityId = CitiesList.SelectedIndices[0];

                var form = new CityEditor(conts, idx, cityId, source);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите город!", "Внимание!");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cityId = CitiesList.SelectedIndices[0];
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранный город?", "Удаление города", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    doc.DeleteCity(source, idx[0], idx[1], idx[2], cityId);
                    RefreshList();

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите город!", "Внимание!");
            }
        }

        public void RefreshList()
        {
            conts = doc.GetData(source);
            CitiesList.Items.Clear();
            SetCitiesData();
        }

        private void Cities_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
