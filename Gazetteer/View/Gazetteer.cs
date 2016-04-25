using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Gazetteer
{
    public partial class Gazetteer : Form
    {
        public List<Continent> conts;
        

        public Gazetteer()
        {
            InitializeComponent();
        }

        public Gazetteer(List<Continent> cs)
        {
            this.conts = cs;
            InitializeComponent();
        }


        private void Gazetteer_Load(object sender, EventArgs e)
        {
            conts = GetData("Data.xml");
            FillList();

            for (int i = 0; i < conts.Count; i++)
            {
                comboBox1.Items.Add(conts[i].Name);
            }
        }


      
        

        private void button3_Click(object sender, EventArgs e)
        {
            List<City> res = new List<City>();

            for (int i = 0; i < conts.Count; i++)
            {
                res.AddRange(conts[i].SearchCitiesHomonyms(textBox1.Text));
            }

            if (res.Count > 0 && textBox1.Text != "")
            {
                var cities = new Cities(res, textBox1.Text);
                cities.Show();
            }
            else
                MessageBox.Show("Города не найдены");

        }

        public static List<Continent> GetData(string source)
        {
            List<Continent> conts = new List<Continent>();
            XmlDocument doc = new XmlDocument();
            doc.Load(source);

            XmlNode root = doc.DocumentElement;

            for (int h = 0; h < root.ChildNodes.Count; h++)
            {
                string ContName = root.ChildNodes[h].FirstChild.LastChild.Value;
                double ContArea = double.Parse(root.ChildNodes[h].ChildNodes[1].LastChild.Value);

                XmlNode coun = root.ChildNodes[h].ChildNodes[2];
                List<Country> countries = new List<Country>();

                for (int i = 0; i < coun.ChildNodes.Count; i++)
                {
                    string Cname = coun.ChildNodes[i].FirstChild.LastChild.Value;
                    double Cpop = double.Parse(coun.ChildNodes[i].ChildNodes[2].LastChild.Value);
                    double Carea = double.Parse(coun.ChildNodes[i].ChildNodes[1].LastChild.Value);
                    string Cgov = coun.ChildNodes[i].ChildNodes[3].LastChild.Value;
                    string Ccap = coun.ChildNodes[i].ChildNodes[4].LastChild.Value;

                    XmlNode lang = coun.ChildNodes[i].ChildNodes[5];
                    List<string> Clangs = new List<string>();

                    for (int j = 0; j < lang.ChildNodes.Count; j++)
                    {
                        Clangs.Add(lang.ChildNodes[j].LastChild.Value);
                    }

                    XmlNode rgs = coun.ChildNodes[i].ChildNodes[6];
                    List<Region> Cregs = new List<Region>();

                    for (int k = 0; k < rgs.ChildNodes.Count; k++)
                    {
                        string Rname = rgs.ChildNodes[k].FirstChild.LastChild.Value;
                        double Rpop = double.Parse(rgs.ChildNodes[k].ChildNodes[2].LastChild.Value);
                        double Rarea = double.Parse(rgs.ChildNodes[k].ChildNodes[1].LastChild.Value);
                        string Rtype = rgs.ChildNodes[k].ChildNodes[3].LastChild.Value;
                        string Rcenter = rgs.ChildNodes[k].ChildNodes[4].LastChild.Value;

                        XmlNode cts = rgs.ChildNodes[k].ChildNodes[5];
                        List<City> cities = new List<City>();

                        for (int l = 0; l < cts.ChildNodes.Count; l++)
                        {
                            string name = cts.ChildNodes[l].FirstChild.LastChild.Value;
                            double pop = double.Parse(cts.ChildNodes[l].ChildNodes[2].LastChild.Value);
                            double area = double.Parse(cts.ChildNodes[l].ChildNodes[1].LastChild.Value);
                            string cityReg = $"{Cname}; {Rtype}: {Rname}";
                            string lat = cts.ChildNodes[l].ChildNodes[3].LastChild.Value;
                            string lon = cts.ChildNodes[l].ChildNodes[4].LastChild.Value;

                            cities.Add(new City(name, pop, area, cityReg, lat, lon));
                        }

                        Cregs.Add(new Region(Rname, Rpop, Rarea, Rtype, cities, Rcenter));
                    }

                    countries.Add(new Country(Cname, Cpop, Carea, Cgov, Ccap, Cregs, Clangs));
                }

                conts.Add(new Continent(ContName, ContArea, countries));
            }

            return conts;
        }

        public void FillList()
        {
            for (int i = 0; i < conts.Count; i++)
            {
                for (int j = 0; j < conts[i].Countries.Count; j++)
                {
                    string[] info = new string[6];
                    info[0] = conts[i].Name;

                    for (int k = 1; k < info.Length; k++)
                    {
                        info[k] = conts[i].Countries[j].GetInfo()[k - 1];
                    }

                    ListViewItem list = new ListViewItem(info);
                    listView1.Items.AddRange(new ListViewItem[] { list });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pop = Math.Round(conts[comboBox1.SelectedIndex].GetPopulation()/1000, 3);
                label1.Text = pop.ToString() + " млн чел";
            }
            catch
            {
                MessageBox.Show("Не выбран континент");
            }
        }
    }
}
