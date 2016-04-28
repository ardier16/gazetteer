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
    public partial class CityEditor : Form
    {
        List<Continent> conts;
        int[] idx;
        string source;
        DocumentEditor doc = new DocumentEditor();

        public CityEditor(List<Continent> c, int[] idx, int cId, string s)
        {
            this.conts = c;
            this.idx = new int[] { idx[0], idx[1], idx[2], cId };
            this.source = s;
            InitializeComponent();
        }

        public CityEditor(List<Continent> c, int[] idx, string s)
        {
            this.conts = c;
            this.idx = new int[] { idx[0], idx[1], idx[2], -1 };
            this.source = s;
            InitializeComponent();
        }

        public CityEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {           
                string Cname = name.Text;
                double Carea = double.Parse(area.Text);
                double Cpop = double.Parse(pop.Text);

                string lon = lonD.Value + "°" + lonM.Value + "′" + lonS.Value + "″ ";
                string lat = latD.Value + "°" + latM.Value + "′" + latS.Value + "″ ";

                if (lonW.Checked)
                    lon += "в. д.";
                else
                    lon += "з. д.";

                if (latN.Checked)
                    lat += "с. ш.";
                else
                    lat += "ю. ш.";

                if (Cname == "" || Carea <= 0 || Cpop <= 0)
                {
                    MessageBox.Show("Заполните поля формы правильно!");
                    return;
                }

                if (idx[3] == -1)
                    doc.AddCity(source, idx[0], idx[1], idx[2], Cname, Carea, Cpop, lat, lon);
                else
                    doc.EditCity(source, idx[0], idx[1], idx[2], idx[3], Cname, Carea, Cpop, lat, lon);
                

                MessageBox.Show("Изменения сохранены!");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CityEditor_Load(object sender, EventArgs e)
        {
            if (idx[3] != -1)
            {
                City c = conts[idx[0]].Countries[idx[1]].Regions[idx[2]].Cities[idx[3]];

                name.Text = c.Name;
                area.Text = c.Area.ToString();
                pop.Text = c.Population.ToString();

                int[] lon = c.GetLongitude();
                int[] lat = c.GetLatitude();

                latD.Value = lat[0];
                latM.Value = lat[1];
                latS.Value = lat[2];

                lonD.Value = lon[0];
                lonM.Value = lon[1];
                lonS.Value = lon[2];

                if (lon[3] == 0)
                    lonW.Checked = true;
                if (lat[3] == 0)
                    latSou.Checked = true;
            }
        }
    }
}
