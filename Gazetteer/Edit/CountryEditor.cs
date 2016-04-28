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
    public partial class CountryEditor : Form
    {
        List<Continent> conts;
        int[] idx;
        string source;

        public CountryEditor()
        {
            InitializeComponent();
        }

        public CountryEditor(List<Continent> c, int[] i, string s)
        {
            conts = c;
            idx = i;
            source = s;
            InitializeComponent();
        }

        public CountryEditor(List<Continent> c, string s)
        {
            conts = c;
            source = s;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DocumentEditor doc = new DocumentEditor();
            List<string> list = new List<string>();

            string[] rich = richTextBox1.Text.Split('\n');

            foreach (string l in rich)
            {
                if (l != "")
                    list.Add(l);
            }


            try
            {
                for (int i = 0; i < conts.Count; i++)
                {
                    if (textBox1.Text != "" && conts[i].SearchCountryByName(textBox1.Text) != null)
                    {
                        MessageBox.Show("Страна с таким названием уже имеется");
                        return;
                    }
                }

                string name = textBox1.Text;
                double area = double.Parse(textBox2.Text);
                double pop = double.Parse(textBox3.Text);
                string gov = textBox4.Text;
                string cap = textBox5.Text;

                if (name == "" || gov == "" || cap == "")
                    MessageBox.Show("Заполните поля формы!");

                if (idx == null)
                    doc.AddCountry(source, comboBox1.SelectedIndex, name, area, pop, gov, cap, list);
                else
                    doc.EditCountry(source, idx[0], idx[1], name, area, pop, gov, cap, list);

                MessageBox.Show("Изменения сохранены!");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }



        }

        private void AddCountry_Load(object sender, EventArgs e)
        {
            

            if (idx != null)
            {
                Country coun = conts[idx[0]].Countries[idx[1]];

                label8.Text = coun.Name;
                comboBox1.Visible = false;
                label7.Visible = false;

                textBox1.Text = coun.Name;
                textBox2.Text = coun.Area.ToString();
                textBox3.Text = coun.Population.ToString();
                textBox4.Text = coun.Government;
                textBox5.Text = coun.Capital;

                string res = "";

                foreach (string l in coun.Languages)
                {
                    res += l + "\n";
                }

                richTextBox1.Text = res;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
