using System;
using System.Collections.Generic;
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
            FillContsBox();           
        }       

        

        private void GetContPopulation_Click(object sender, EventArgs e)
        {
            try
            {
                double pop = Math.Round(conts[ContsPopBox.SelectedIndex].Population / 1000, 3);
                ContPopResult.Text = "Суммарное население: " + pop.ToString() + " млн чел";
            }
            catch
            {
                MessageBox.Show("Не выбран континент");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<City> res = new List<City>();

            for (int i = 0; i < conts.Count; i++)
            {
                res.AddRange(conts[i].SearchCitiesHomonyms(SearchField.Text, StartSearchPos.Checked));
            }

            if (res.Count > 0 && SearchField.Text != "")
            {
                var cities = new Cities(res, SearchField.Text);
                cities.Show();
            }
            else
                MessageBox.Show("Города не найдены");
        }

        private void CountriesList_DoubleClick(object sender, EventArgs e)
        {
            if (CountriesList.SelectedIndices.Count == 1)
            {
                Country c = null;

                for (int i = 0; i < conts.Count; i++)
                {
                    c = conts[i].SearchCountryByName(
                        CountriesList.Items[CountriesList.SelectedIndices[0]].SubItems[1].Text);

                    if (c != null)
                        break;
                }

                var CountryInfo = new CountryInfo(c);
                CountryInfo.ShowDialog();
            }
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
                    CountriesList.Items.AddRange(new ListViewItem[] { list });
                }
            }
        }

        public void FillContsBox()
        {
            for (int i = 0; i < conts.Count; i++)
            {
                ContsPopBox.Items.Add(conts[i].Name);
            }
        }
    }
}
