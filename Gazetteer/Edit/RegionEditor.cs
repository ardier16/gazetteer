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
    public partial class RegionEditor : Form
    {
        List<Continent> conts;
        int[] idx;
        string source;
        int regId;

        public RegionEditor()
        {
            InitializeComponent();
        }

        public RegionEditor(List<Continent> c, int[] i, string s)
        {
            this.conts = c;
            this.idx = i;
            this.source = s;
            this.regId = -1;
            InitializeComponent();
        }

        public RegionEditor(List<Continent> c, int[] i, int regId, string s)
        {
            this.conts = c;
            this.idx = i;
            this.source = s;
            this.regId = regId;
            InitializeComponent();
        }

        private void RegionEditor_Load(object sender, EventArgs e)
        {
            if (regId != -1)
            {
                Region reg = conts[idx[0]].Countries[idx[1]].Regions[regId];

                name.Text = reg.Name;
                area.Text = reg.Area.ToString();
                pop.Text = reg.Population.ToString();
                type.Text = reg.RegionType;
                cen.Text = reg.Center;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DocumentEditor doc = new DocumentEditor();
            List<string> list = new List<string>();

            try
            {
                for (int i = 0; i < conts.Count; i++)
                {
                    if ((name.Text != "" && conts[idx[0]].Countries[idx[1]].SearchRegionByName(name.Text) != null &&
                        regId != -1 && conts[idx[0]].Countries[idx[1]].SearchRegionByName(name.Text).Name != 
                        conts[idx[0]].Countries[idx[1]].Regions[regId].Name) || (regId == -1 && name.Text != "" && 
                        conts[idx[0]].Countries[idx[1]].SearchRegionByName(name.Text) != null))
                    {
                        MessageBox.Show("Регион с таким названием уже имеется");
                        return;
                    }
                }

                string Rname = name.Text;
                double Rarea = double.Parse(area.Text);
                double Rpop = double.Parse(pop.Text);
                string Rtype = type.Text;
                string Rcen = cen.Text;

                if (Rname == "" || Rtype == "" || Rcen == "" || Rarea <= 0 || Rpop <= 0)
                {
                    MessageBox.Show("Заполните поля формы правильно!");
                    return;
                }
                    

                if (regId == -1)
                    doc.AddRegion(source, idx[0], idx[1], Rname, Rarea, Rpop, Rtype, Rcen);
                else
                    doc.EditRegion(source, idx[0], idx[1], regId, Rname, Rarea, Rpop, Rtype, Rcen);

                MessageBox.Show("Изменения сохранены!");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }
    }
}
