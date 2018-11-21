using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Cities : Form
    {
        public string SearchInfo;
        string user;
        int regId;
        string searchCities;
        bool isFiltered;


        public Cities()
        {
            InitializeComponent();
        }

        public Cities(int id, string u)
        {
            regId = id;
            user = u;
            InitializeComponent();
        }

        public Cities(string search, string u)
        {
            searchCities = search;
            user = u;
            InitializeComponent();
        }


        private void Cities_Load(object sender, EventArgs e)
        {
            SetCitiesData();
        }

        private void Cities_Activated(object sender, EventArgs e)
        {
            Cities_Load(null, null);
        }


        private void AddMenu_Click(object sender, EventArgs e)
        {
            isFiltered = false;
            var form = new CityEditor(regId);
            form.ShowDialog();
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {
            try
            {
                isFiltered = false;
                var form = new CityEditor(regId, Convert.ToInt32(CitiesTable.SelectedRows[0].Cells[0].Value.ToString()));
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string city = CitiesTable.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete selected city?", "Delete City", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    City.DeleteCity(city, regId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void ShowMapBtn_Click(object sender, EventArgs e)
        {
            List<string> idcs = new List<string>();
            isFiltered = false;

            for (int i = 0; i < CitiesTable.SelectedRows.Count; i++)
            {
                idcs.Add(CitiesTable.SelectedRows[i].Cells[0].Value.ToString());
            }

            var form = new Map(idcs, user);
            form.ShowDialog();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            isFiltered = true;
            Cities_Load(null, null);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            isFiltered = false;
            AreaMinField.Value = PopMinField.Value = YearMinField.Value = 0;
            Cities_Load(null, null);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    OKButton_Click(null, null);
                    this.Close();
                    break;
                case Keys.Enter:
                    OKButton_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void SetCitiesData()
        {
            menuStrip1.Visible = User.GetUserData(user) == "Yes";

            string query = @"SELECT CityId AS ID, CityName AS Name, CityLongitude AS Longitude, CityLatitude AS Latitude,  
                CityArea AS Area, CityPopulation AS Population, CityBuildYear AS 'Build Year', CityLeader AS Leader FROM City";

            if (regId > 0)
            {
                string subquery = " WHERE RegionId=" + regId;

                if (isFiltered)
                    subquery += String.Format(@" AND CityArea BETWEEN '{0}' AND '{1}' AND CityPopulation BETWEEN '{2}' AND 
                                                '{3}' AND CityBuildYear BETWEEN '{4}' AND '{5}'",
                        AreaMinField.Value.ToString(), AreaMaxField.Value.ToString(), PopMinField.Value.ToString(),
                        PopMaxField.Value.ToString(), YearMinField.Value.ToString(), YearMaxField.Value.ToString());
                else
                {
                    try
                    {
                        AreaMinField.Maximum = AreaMaxField.Value = AreaMaxField.Maximum =
                            Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CityArea) FROM City" + subquery).Rows[0].ItemArray[0].ToString());
                        PopMinField.Maximum = PopMaxField.Value = PopMaxField.Maximum =
                            Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CityPopulation) FROM City" + subquery).Rows[0].ItemArray[0].ToString());
                        YearMinField.Maximum = YearMaxField.Value = YearMaxField.Maximum =
                            Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CityBuildYear) FROM City" + subquery).Rows[0].ItemArray[0].ToString());
                    }
                    catch { }
                }

                CitiesTable.DataSource = SQLEditor.DoSqlOperation(query + subquery);
                InfoField.Text = "Region's cities";

                CitiesTable.Columns[0].Visible = false;
            }

            else if (searchCities != null)
            {
                string subquery = " WHERE CityName LIKE '" + searchCities + "'";

                if (isFiltered)
                    subquery += String.Format(@" AND CityArea BETWEEN '{0}' AND '{1}' AND CityPopulation BETWEEN '{2}' AND '{3}' AND 
                                              CityBuildYear BETWEEN '{4}' AND '{5}'",
                            AreaMinField.Value.ToString(), AreaMaxField.Value.ToString(), PopMinField.Value.ToString().Replace(',', '.'),
                            PopMaxField.Value.ToString().Replace(',', '.'), YearMinField.Value.ToString(), YearMaxField.Value.ToString());
                else
                {
                    try
                    {
                        AreaMinField.Maximum = AreaMaxField.Value = AreaMaxField.Maximum =
                            Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CityArea) FROM City" + subquery).Rows[0].ItemArray[0].ToString());
                        PopMinField.Maximum = PopMaxField.Value = PopMaxField.Maximum =
                            Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CityPopulation) FROM City" + subquery).Rows[0].ItemArray[0].ToString());
                        YearMinField.Maximum = YearMaxField.Value = YearMaxField.Maximum =
                            Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CityBuildYear) FROM City" + subquery).Rows[0].ItemArray[0].ToString());
                    }
                    catch
                    {
                        AreaMinField.Maximum = AreaMaxField.Value = AreaMaxField.Maximum = PopMinField.Maximum = PopMaxField.Value = PopMaxField.Maximum =
                            YearMinField.Maximum = YearMaxField.Value = YearMaxField.Maximum = 0;
                    }
                }

                CitiesTable.DataSource = SQLEditor.DoSqlOperation(query + subquery);
                InfoField.Text = "Search results: " + searchCities.Replace('%', ' ');
                menuStrip1.Visible = false;
                CitiesTable.Columns[0].Visible = false;
            }
        }
    }
}
