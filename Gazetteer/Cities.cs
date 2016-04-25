using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Cities : Form
    {
        public List<City> cities;
        public string SearchKey;

        public Cities()
        {
            InitializeComponent();
        }

        public Cities(List<City> cs, string s)
        {
            this.cities = cs;
            this.SearchKey = s;
            InitializeComponent();
        }

        private void Cities_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                string[] info = new string[] { cities[i].Name , cities[i].Region, cities[i].Area.ToString(),
                                               cities[i].Population.ToString(), cities[i].Latitude, cities[i].Longitude};
         
                ListViewItem list = new ListViewItem(info);
                listView1.Items.AddRange(new ListViewItem[] { list });
                
            }

            label2.Text = SearchKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    button1_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
