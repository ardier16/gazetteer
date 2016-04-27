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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////private void button1_Click(object sender, EventArgs e)
        ////{
        ////    //XmlDocument doc = new XmlDocument();
        ////    //doc.Load("Data.xml");

        ////    //XmlNode root = doc.DocumentElement;

        ////    //XmlNode reg = root.ChildNodes[5].ChildNodes[2].FirstChild.ChildNodes[6];

        ////    //XmlElement rg = doc.CreateElement("region");
        ////    //reg.AppendChild(rg);

        ////    //XmlElement name = doc.CreateElement("name");
        ////    //name.InnerText = textBox1.Text;
        ////    //XmlElement area = doc.CreateElement("area");
        ////    //area.InnerText = textBox2.Text;
        ////    //XmlElement pop = doc.CreateElement("population");
        ////    //pop.InnerText = textBox3.Text;
        ////    //XmlElement type = doc.CreateElement("type");
        ////    //type.InnerText = textBox4.Text;
        ////    //XmlElement center = doc.CreateElement("center");
        ////    //center.InnerText = textBox5.Text;
        ////    //XmlElement c = doc.CreateElement("cities");
        ////    //c.InnerText = "";

        ////    //rg.AppendChild(name);
        ////    //rg.AppendChild(area);
        ////    //rg.AppendChild(pop);
        ////    //rg.AppendChild(type);
        ////    //rg.AppendChild(center);
        ////    //rg.AppendChild(c);

        ////    //doc.Save("Data.xml");

        ////    List<Continent> cont = GetData("Data.xml");

        ////    label6.Text = "ADDED";
        ////    textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = "";
        ////}



        ////private void button2_Click_1(object sender, EventArgs e)
        ////{
        ////    XmlDocument doc = new XmlDocument();
        ////    doc.Load("Data.xml");

        ////    XmlNode root = doc.DocumentElement;

        ////    XmlNode reg = root.ChildNodes[5].ChildNodes[2].FirstChild.ChildNodes[6].ChildNodes[(int)numericUpDown1.Value].LastChild;

        ////    XmlElement rg = doc.CreateElement("city");
        ////    reg.AppendChild(rg);

        ////    XmlElement name = doc.CreateElement("name");
        ////    name.InnerText =}
        ////textBox6.Text;
        ////    XmlElement area = doc.CreateElement("area");
        ////area.InnerText = textBox7.Text;
        ////    XmlElement pop = doc.CreateElement("population");
        ////pop.InnerText = textBox8.Text;
        ////    XmlElement lat = doc.CreateElement("latitude");
        ////lat.InnerText = textBox9.Text;
        ////    XmlElement lon = doc.CreateElement("longitude");
        ////lon.InnerText = textBox10.Text;

        ////    rg.AppendChild(name);
        ////    rg.AppendChild(area);
        ////    rg.AppendChild(pop);
        ////    rg.AppendChild(lat);
        ////    rg.AppendChild(lon);

        ////    doc.Save("Data.xml");

        ////    label6.Text = "OK";
        ////    textBox6.Text = textBox7.Text = textBox8.Text = "";
    }
}
