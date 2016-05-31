using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Gazetteer : Form
    {
        public List<Continent> conts;
        public DocumentEditor doc = new DocumentEditor();
        public string source;
        
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
            try
            {
                source = "Data.xml";
                conts = doc.GetData(source);
                FillList();
                FillContsBox();
            }
            catch
            {
                MessageBox.Show("Файл Data.xml не найден или имеет неизвестный формат");
                создатьToolStripMenuItem1_Click(null, null);
                conts = doc.GetData(source);
                FillList();
                FillContsBox();
            }                  
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

            if (SearchField.Text != "")
            {
                res = SearchCities(SearchField.Text);
            }

            else
            {
                res = SearchCitiesHomonyms();
            }

            if (res.Count > 0)
            {
                var cities = new Cities(res, SearchField.Text, source);
                cities.ShowDialog();
            }
            else
                MessageBox.Show("Города не найдены");
        }

        private void CountriesList_DoubleClick(object sender, EventArgs e)
        {
            if (CountriesList.SelectedIndices.Count == 1)
            {
                string name = CountriesList.Items[CountriesList.SelectedIndices[0]].SubItems[1].Text;
                int[] idx = GetCountryIndex(conts, name);

                var CountryInfo = new CountryInfo(idx, conts, source);
                CountryInfo.ShowDialog();
            }
        }

        private void Gazetteer_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string oldSource = source;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                source = openFileDialog1.FileName;
            }
            
            try
            {
                conts = doc.GetData(source);
            }
            catch
            {                
                source = oldSource;
                conts = doc.GetData(source);
                MessageBox.Show("Файл повреждён или имеет неизвестный формат");
            }
            finally
            {
                CountriesList.Items.Clear();
                FillList();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new CountryEditor(conts, source);
            addForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] idx = GetCountryIndex(conts, CountriesList.SelectedItems[0].SubItems[1].Text);

                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранную страну?", "Удаление страны", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    doc.DeleteCountry(source, idx[0], idx[1]);
                    RefreshList();

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите страну!", "Внимание!");
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] k = GetCountryIndex(conts, CountriesList.SelectedItems[0].SubItems[1].Text);

                Country c = null;

                for (int i = 0; i < conts.Count; i++)
                {
                    c = conts[i].SearchCountryByName(
                        CountriesList.Items[CountriesList.SelectedIndices[0]].SubItems[1].Text);

                    if (c != null)
                        break;
                }

                var form = new CountryEditor(conts, k, source);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите страну!", "Внимание!");
            }
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    doc.CreateNewBase(saveFileDialog1.FileName);
                    source = saveFileDialog1.FileName;
                    CountriesList.Items.Clear();
                    FillList();
                    RefreshList();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при создании файла");
            }
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

        public void RefreshList()
        {
            conts = doc.GetData(source);
            CountriesList.Items.Clear();
            FillList();
        }




        public List<City> SearchCities(string key)
        {
            List<City> res = new List<City>();

            for (int i = 0; i < conts.Count; i++)
            {
                res.AddRange(conts[i].SearchCities(key, StartSearchPos.Checked));
            }

            return res;
        }

        public List<City> SearchCitiesHomonyms()
        {
            List<City> res = new List<City>();

            for (int i = 0; i < conts.Count; i++)
            {
                for (int j = 0; j < conts[i].Countries.Count; j++)
                {
                    for (int k = 0; k < conts[i].Countries[j].Regions.Count; k++)
                    {
                        for (int l = 0; l < conts[i].Countries[j].Regions[k].Cities.Count; l++)
                        {
                            City temp = conts[i].Countries[j].Regions[k].Cities[l];
                            List<City> search = SearchCities(temp.Name);

                            if (search.Count > 1)
                                res.AddRange(search);

                        }
                    }
                }
            }

            return RemoveSameCities(res);
        }

        public List<City> RemoveSameCities(List<City> source)
        {
            for (int i = 0; i < source.Count; i++)
            {
                for (int j = i + 1; j < source.Count; j++)
                {
                    if (source[i].Latitude == source[j].Latitude &&
                        source[i].Longitude == source[j].Longitude)
                    {
                        source.RemoveAt(j);
                        j--;
                    }
                }
            }

            return source;
        }

        public int[] GetCountryIndex(List<Continent> conts, string name)
        {
            for (int i = 0; i < conts.Count; i++)
            {
                for (int j = 0; j < conts[i].Countries.Count; j++)
                {
                    if (conts[i].Countries[j].Name == name)
                        return new int[] { i, j };
                }
            }

            return new int[0];
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Map(conts);
            form.ShowDialog();
        }


    }
}
