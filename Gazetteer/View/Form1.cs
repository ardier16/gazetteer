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
        public Gazetteer()
        {
            InitializeComponent();
        }

        //List<Continent> conts = GetData("Data.xml");

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Data.xml");

            XmlNode root = doc.DocumentElement;

            XmlNode reg = root.FirstChild.ChildNodes[2].FirstChild.ChildNodes[6];

            XmlElement rg = doc.CreateElement("region");
            reg.AppendChild(rg);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = textBox1.Text;
            XmlElement area = doc.CreateElement("area");
            area.InnerText = textBox2.Text;
            XmlElement pop = doc.CreateElement("population");
            pop.InnerText = textBox3.Text;
            XmlElement type = doc.CreateElement("type");
            type.InnerText = textBox4.Text;
            XmlElement center = doc.CreateElement("center");
            center.InnerText = textBox5.Text;
            XmlElement c = doc.CreateElement("cities");
            c.InnerText = "";

            rg.AppendChild(name);
            rg.AppendChild(area);
            rg.AppendChild(pop);
            rg.AppendChild(type);
            rg.AppendChild(center);
            rg.AppendChild(c);

            doc.Save("Data.xml");

            label6.Text = "ADDED";
        }

        public List<Continent> GetData(string source)
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
                            string lat = cts.ChildNodes[l].ChildNodes[3].LastChild.Value;
                            string lon = cts.ChildNodes[l].ChildNodes[4].LastChild.Value;

                            cities.Add(new City(name, pop, area, lat, lon));
                        }

                        Cregs.Add(new Region(Rname, Rpop, Rarea, Rtype, cities, Rcenter));
                    }

                    countries.Add(new Country(Cname, Cpop, Carea, Cgov, Ccap, Cregs, Clangs));
                }

                conts.Add(new Continent(ContName, ContArea, countries));
            }

            return conts;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Data.xml");

            XmlNode root = doc.DocumentElement;

            XmlNode reg = root.FirstChild.ChildNodes[2].FirstChild.ChildNodes[6].ChildNodes[(int)numericUpDown1.Value].LastChild;

            XmlElement rg = doc.CreateElement("city");
            reg.AppendChild(rg);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = textBox6.Text;
            XmlElement area = doc.CreateElement("area");
            area.InnerText = textBox7.Text;
            XmlElement pop = doc.CreateElement("population");
            pop.InnerText = textBox8.Text;
            XmlElement lat = doc.CreateElement("latitude");
            lat.InnerText = textBox9.Text;
            XmlElement lon = doc.CreateElement("longitude");
            lon.InnerText = textBox10.Text;

            rg.AppendChild(name);
            rg.AppendChild(area);
            rg.AppendChild(pop);
            rg.AppendChild(lat);
            rg.AppendChild(lon);

            doc.Save("Data.xml");

            label6.Text = "OK";
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
        }
    }
}
