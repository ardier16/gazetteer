using System;
using System.Collections.Generic;
using System.Xml;

namespace Gazetteer
{
    public class DocumentEditor
    {
        XmlDocument doc = new XmlDocument();


        public List<Continent> GetData(string source)
        {
            List<Continent> conts = new List<Continent>();
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

        public void AddCountry(string source, int ContId, string name, double area, 
                               double pop, string gov, string cap, List<string> langs)
        {
            
            doc.Load(source);

            XmlNode root = doc.DocumentElement;

            XmlNode counts = root.ChildNodes[ContId].ChildNodes[2];

            XmlElement coun = doc.CreateElement("country");
            counts.AppendChild(coun);

            XmlNode cont = counts.LastChild;

            XmlElement Cname = doc.CreateElement("name");
            Cname.InnerText = name;
            XmlElement Carea = doc.CreateElement("area");
            Carea.InnerText = area.ToString();
            XmlElement Cpop = doc.CreateElement("population");
            Cpop.InnerText = pop.ToString();
            XmlElement Cgov = doc.CreateElement("government");
            Cgov.InnerText = gov;
            XmlElement Ccap = doc.CreateElement("capital");
            Ccap.InnerText = cap;
            XmlElement Clangs = doc.CreateElement("languages");
            Clangs.InnerText = "";
            XmlElement regs = doc.CreateElement("regions");
            regs.InnerText = "";

            cont.AppendChild(Cname);
            cont.AppendChild(Carea);
            cont.AppendChild(Cpop);
            cont.AppendChild(Cgov);
            cont.AppendChild(Ccap);
            cont.AppendChild(Clangs);

            XmlNode Langs = cont.LastChild;
            foreach(string l in langs)
            {
                XmlElement lang = doc.CreateElement("language");
                lang.InnerText = l;
                Langs.AppendChild(lang);
            }

            cont.AppendChild(regs);

            doc.Save(source);
        }

        public void EditCountry(string source, int ContId, int CounId, string name, double area,
                               double pop, string gov, string cap, List<string> langs)
        {
            doc.Load(source);
            XmlNode root = doc.DocumentElement;

            XmlNode coun = root.ChildNodes[ContId].ChildNodes[2].ChildNodes[CounId];

            coun.FirstChild.InnerText = name;
            coun.ChildNodes[1].InnerText = area.ToString();
            coun.ChildNodes[2].InnerText = pop.ToString();
            coun.ChildNodes[3].InnerText = gov;
            coun.ChildNodes[4].InnerText = cap;

            XmlNode Langs = coun.ChildNodes[5];


            if (Langs.ChildNodes.Count <= langs.Count)
            {
                for (int i = 0; i < langs.Count; i++)
                {
                    if (Langs.ChildNodes[i] != null)
                        Langs.ChildNodes[i].InnerText = langs[i];
                    else
                    {
                        XmlElement lang = doc.CreateElement("language");
                        lang.InnerText = langs[i];
                        Langs.AppendChild(lang);
                    }
                }
            }
            else
            {
                for (int i = 0; i < Langs.ChildNodes.Count; i++)
                {
                    if (i < langs.Count)
                        Langs.ChildNodes[i].InnerText = langs[i];
                    else
                    {
                        while (Langs.ChildNodes[i] != null)
                            Langs.RemoveChild(Langs.ChildNodes[i]);
                    }
                }
            }
            

            doc.Save(source);

        }

        public void DeleteCountry(string source, int ContId, int CounId)
        {
            List<Continent> conts = new List<Continent>();
            doc.Load(source);

            XmlNode root = doc.DocumentElement;

            XmlNode couns = root.ChildNodes[ContId].ChildNodes[2];

            couns.RemoveChild(couns.ChildNodes[CounId]);

            doc.Save(source);
        }

        public void CreateNewBase(string source)
        {

            doc.LoadXml("<?xml version='1.0' encoding='utf-8'?> <gazetteer> <continent> <name>Европа</name> <area>10180</area> <countries> </countries> </continent> <continent> <name>Азия</name> <area>44579</area> <countries> </countries> </continent> <continent> <name>Африка</name> <area>30221,532</area> <countries> </countries> </continent> <continent> <name>Северная Америка</name> <area>24250</area> <countries> </countries> </continent> <continent> <name>Южная Америка</name> <area>17840</area> <countries> </countries> </continent> <continent> <name>Австралия и Океания</name> <area>8520</area> <countries> </countries> </continent> <continent> <name>Антарктида</name> <area>14107</area> <countries> </countries> </continent> </gazetteer>");
            doc.Save(source);
        }
    }
}
