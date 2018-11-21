using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using Word = Microsoft.Office.Interop.Word;

namespace Gazetteer
{
    public partial class CountryInfo : Form
    {
        string country;
        string user;


        public CountryInfo()
        {
            InitializeComponent();
        }

        public CountryInfo(string counName, string u)
        {
            country = counName;
            user = u;
            InitializeComponent();
        }


        private void CountryInfo_Load(object sender, EventArgs e)
        {
            if (user != null && User.GetUserData(user) == "Yes")
                editRegionToolStripMenuItem.Visible = true;
            if (user != null)
                saveAsDocToolStripMenuItem.Visible = true;

            SetCountryData();
            RefreshTable();
        }


        private void CountryInfo_Activated(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void addRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RegionEditor(country);
            form.ShowDialog();
        }

        private void editRegionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = RegionsTable.SelectedRows[0].Cells[0].Value.ToString();
                int id = State.GetRegionId(name, country);
                var form = new RegionEditor(id);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите регион!", "Внимание!");
            }
        }

        private void deleteRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = RegionsTable.SelectedRows[0].Cells[0].Value.ToString();
                State.DeleteRegion(name, country);
                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new Cities(State.GetRegionId(RegionsTable.SelectedRows[0].Cells[0].Value.ToString(), country), user);
            form.ShowDialog();
        }


        private void saveAsDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Application winword = new Word.Application();
                winword.Visible = false;
                winword.Documents.Application.Caption = country;
                object missing = System.Reflection.Missing.Value;
                Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);


                Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.Font.Name = "Arial";
                para1.Range.Font.Size = 18;
                para1.Range.Font.Bold = 1;
                para1.Range.Font.Italic = 1;
                para1.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                para1.Range.ParagraphFormat.SpaceAfter = 1;
                para1.Range.Text = country + "\n";
                para1.Range.InsertParagraphAfter();

                Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                para2.Range.Font.Name = "Arial";
                para2.Range.Font.Size = 12;
                para2.Range.ParagraphFormat.SpaceAfter = 1;
                para2.Range.Text = "Area: " + CountryArea.Text + "\n" + "Population: " + CountryPop.Text + "\n" + "Continent: " + CountryCont.Text + "\n" + 
                    "Government: " + CountryGov.Text + "\n" + "Capital: " + CountryCap.Text + "\n" + "Official Languages: " + CountryLangs.Text + "\n" + 
                    "GDP: " + CountryGdp.Text + "\n" + "Leader: " + CountryLeader.Text + "\n" + "Currency: " + CountryCurrency.Text + "\n";
                para2.Range.InsertParagraphAfter();

                Word.Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
                para3.Range.Font.Name = "Arial";
                para3.Range.Font.Size = 18;
                para3.Range.Font.Bold = 1;
                para3.Range.Font.Italic = 1;
                para3.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                para3.Range.ParagraphFormat.SpaceAfter = 1;
                para3.Range.Text = "Regions \n";
                para3.Range.InsertParagraphAfter();

                Word.Table firstTable = document.Tables.Add(para3.Range, RegionsTable.Rows.Count+1, RegionsTable.ColumnCount, ref missing, ref missing);

                firstTable.Borders.Enable = 1;

                for (int i = 1; i <= firstTable.Rows.Count; i++)
                {
                    for (int j = 1; j <= firstTable.Rows[i].Cells.Count; j++)
                    {
                        if (i == 1)
                        {
                            firstTable.Rows[i].Cells[j].Range.Font.Bold = 1;
                            firstTable.Rows[i].Cells[j].Range.Font.Italic = 1;
                            firstTable.Rows[i].Cells[j].Range.Font.Name = "verdana";
                            firstTable.Rows[i].Cells[j].Range.Font.Size = 11;
                            firstTable.Rows[i].Cells[j].Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
                            firstTable.Rows[i].Cells[j].TopPadding = 6;
                            firstTable.Rows[i].Cells[j].VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                            firstTable.Rows[i].Cells[j].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            firstTable.Rows[i].Cells[j].Range.Text = RegionsTable.Columns[j-1].HeaderText;

                        }
                        else
                        {
                            firstTable.Rows[i].Cells[j].Range.Font.Name = "verdana";
                            firstTable.Rows[i].Cells[j].Range.Font.Size = 10;
                            firstTable.Rows[i].Cells[j].VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            firstTable.Rows[i].Cells[j].TopPadding = 6;
                            firstTable.Rows[i].Cells[j].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                            firstTable.Rows[i].Cells[j].Range.Text = RegionsTable.Rows[i - 2].Cells[j - 1].Value.ToString();
                        }
                    }
                }

                document.Paragraphs[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                document.Paragraphs[13].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].
                    Range.Text = "Today's date: " + DateTime.Now.ToLongDateString() + "; " +
                                 "Time: " + DateTime.Now.ToLongTimeString() + "\n" +
                                 "Copyright © 2016 Gazetteer";
                document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].
                    Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                winword.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SetCountryData()
        {
            DataTable dt = SQLEditor.DoSqlOperation("SELECT * FROM Country WHERE CountryName='" + country + "'");

            CountryName.Text = dt.Rows[0].ItemArray[0].ToString();
            CountryArea.Text = String.Format("{0:N}", Convert.ToInt64(dt.Rows[0].ItemArray[1].ToString()));
            CountryPop.Text = String.Format("{0:N}", Convert.ToInt64(dt.Rows[0].ItemArray[2].ToString()));
            CountryGov.Text = dt.Rows[0].ItemArray[3].ToString();
            CountryGdp.Text = dt.Rows[0].ItemArray[4].ToString();
            CountryLeader.Text = dt.Rows[0].ItemArray[5].ToString();
            CountryCap.Text = City.SearchCityById(dt.Rows[0].ItemArray[6].ToString());
            CountryCont.Text = dt.Rows[0].ItemArray[7].ToString();
            CountryCurrency.Text = dt.Rows[0].ItemArray[8].ToString();

            List<string> langs = Country.GetContryLangs(country);

            string lgs = "";

            for (int i = 0; i < langs.Count; i++)
            {
                lgs += langs[i] + ", ";
            }

            if (lgs.Length > 2)
                CountryLangs.Text = lgs.Substring(0, lgs.Length - 2);
            else
                CountryLangs.Text = "Nope";
        }

        private void RefreshTable()
        {
            RegionsTable.DataSource = SQLEditor.DoSqlOperation(@"SELECT RegionName AS Name, RegionArea AS Area, RegionPopulation As Population,
            RegionType AS Type, 'Nope' AS Center, RegionLeader AS Leader FROM Region WHERE CountryName='" + country + @"' AND RegionCenter IS NULL
            UNION SELECT Region.RegionName AS Name, Region.RegionArea AS Area, Region.RegionPopulation As Population,
            Region.RegionType AS Type, City.CityName AS Center, Region.RegionLeader AS Leader FROM Region, City WHERE Region.CountryName='" +
            country + @"' AND Region.RegionCenter=City.CityId");
        }
    }
}
