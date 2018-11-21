using System;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Gazetteer : Form
    {
        string user;
        string search = "";
        bool isSearched, isFiltered;


        public Gazetteer()
        {
            InitializeComponent();
        }

        public Gazetteer(string user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void Gazetteer_Load(object sender, EventArgs e)
        {
            try
            {
                CheckUser();
                SetTableData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void Gazetteer_Activated(object sender, EventArgs e)
        {
            if (isFiltered)
                SetFilterData();
            else
                SetTableData();
        }

        private void Gazetteer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            isFiltered = true;
            isSearched = false;
            SetFilterData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (StartSearchPos.Checked)
                search = SearchField.Text + "%";
            else
                search = "%" + SearchField.Text + "%";

            if (CounSearch.Checked)
            {
                isSearched = true;
                isFiltered = false;
                SetTableData();
            }

            else if (CtsSearch.Checked)
            {
                var form = new Cities(search, user);
                form.ShowDialog();
            }
        }


        private void CountriesTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new CountryInfo(CountriesTable.SelectedRows[0].Cells[0].Value.ToString(), user);
            form.ShowDialog();
        }


        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddMenu_Click(object sender, EventArgs e)
        {
            var form = new CountryEditor();
            form.ShowDialog();
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {
            var form = new CountryEditor(CountriesTable.SelectedRows[0].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Country.DeleteCountry(CountriesTable.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

            SetTableData();
        }

        
        private void AboutMenu_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }


        private void SignInUpMenu_Click(object sender, EventArgs e)
        {
            var form = new SignIn();
            form.Show();
            this.Visible = false;      
        }


        private void NewGameMenu_Click(object sender, EventArgs e)
        {
            var form = new Map(user);
            form.ShowDialog();
        }


        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AdminPanel();
            form.ShowDialog();
        }


        #region Statistics
        private void top10CountriesByAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Statistics(Country.CountryStat("SELECT TOP 10 CountryName, CountryArea FROM Country ORDER BY CountryArea DESC"), "Top 10 Countries By Area", "Area, sq. km");
            form.ShowDialog();
        }

        private void top10CountriesByPopulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Statistics(Country.CountryStat("SELECT TOP 10 CountryName, CountryPopulation FROM Country ORDER BY CountryPopulation DESC"), "Top 10 Countries By Population", "Population");
            form.ShowDialog();
        }

        private void top10CitiesByAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Statistics(City.CityStat(@"SELECT TOP 10 City.CityName, Country.CountryName, City.CityArea FROM City, Region, Country 
                                        WHERE City.RegionId=Region.RegionId AND Region.CountryName=Country.CountryName ORDER BY City.CityArea DESC"),
                                         "Top 10 Cities By Area", "Area, sq. km");
            form.ShowDialog();
        }

        private void top10CitiesByPopulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Statistics(City.CityStat(@"SELECT TOP 10 City.CityName, Country.CountryName, City.CityPopulation FROM City, Region, Country 
                                        WHERE City.RegionId=Region.RegionId AND Region.CountryName=Country.CountryName ORDER BY City.CityPopulation DESC"),
                                         "Top 10 Cities By Population", "Population");
            form.ShowDialog();
        }

        private void top10MostUsedCurrenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Statistics(Country.CountryStat(@"SELECT TOP 10 CurrencyName, COUNT(CountryName) FROM Country WHERE CurrencyName IS NOT NULL
                                         GROUP BY CurrencyName ORDER BY COUNT(CountryName) DESC"),
                                         "Top 10 Most Used Currencies", "Count Of Countries");
            form.ShowDialog();

        }

        private void top10MostSuccessfullGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Statistics(Country.CountryStat(@"SELECT TOP 10 UserLogin, GameScore FROM Game ORDER BY GameScore DESC"),
                                         "Top 10 Most Successful Games", "Score");
            form.ShowDialog();
        }
        #endregion


        private void sQLEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SQLEdit();
            form.Show();
        }


        private void requestAdminRootsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.UpdateAdmin("Requested", user);
            MessageBox.Show("Admin Roots Requested!");
            requestAdminRootsToolStripMenuItem.Enabled = false;
        }


        private void SetTableData()
        {
            string query = @"SELECT CountryName AS 'Name', CountryArea AS 'Area', CountryPopulation AS 'Population', 
                                CountryGovernment AS 'Government', CountryGDP AS 'GDP', CountryLeader AS 'Leader', 'Nope' AS 'Capital', 
                                ContinentName AS 'Continent', CurrencyName AS 'Currency' FROM Country WHERE CountryCapital IS NULL";

            if (search != "" && isSearched)
                query += " AND CountryName LIKE '" + search + "'";

            query += @" UNION SELECT Country.CountryName AS 'Name', Country.CountryArea AS 'Area', 
                                Country.CountryPopulation AS 'Population', Country.CountryGovernment AS 'Government', Country.CountryGDP AS 'GDP', 
                                Country.CountryLeader AS 'Leader', City.CityName AS 'Capital', Country.ContinentName AS 'Continent', Country.CurrencyName AS 'Currency' 
                                FROM Country, City WHERE Country.CountryCapital=City.CityId";

            if (search != "" && isSearched)
                query += " AND Country.CountryName LIKE '" + search + "'";

            CountriesTable.DataSource = SQLEditor.DoSqlOperation(query);

            try
            {
                MaxAreaField.Value = MaxAreaField.Maximum = Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CountryArea) FROM Country").Rows[0].ItemArray[0].ToString());
                MaxPopField.Value = MaxPopField.Maximum = Convert.ToDecimal(SQLEditor.DoSqlOperation("SELECT MAX(CountryPopulation) FROM Country").Rows[0].ItemArray[0].ToString());
                ContsList.DataSource = SQLEditor.GetCurList("SELECT ContinentName FROM Continent");
                MinAreaField.Maximum = MaxAreaField.Maximum;
                MinPopField.Maximum = MaxPopField.Maximum;
            }
            catch { }
        }

        private void SetFilterData()
        {
            string subquery = String.Format(" AND Country.CountryArea BETWEEN '{0}' AND '{1}' AND Country.CountryPopulation BETWEEN '{2}' AND '{3}'",
                            MinAreaField.Value.ToString(), MaxAreaField.Value.ToString(), MinPopField.Value.ToString().Replace(',', '.'), 
                            MaxPopField.Value.ToString().Replace(',', '.'));

            if (ContsList.Text != "Nope")
                subquery += String.Format(" AND Country.ContinentName='{0}'", ContsList.Text);

            string query = @"SELECT CountryName AS 'Name', CountryArea AS 'Area', CountryPopulation AS 'Population', 
                                CountryGovernment AS 'Government', CountryGDP AS 'GDP', CountryLeader AS 'Leader', 'Nope' AS 'Capital', 
                                ContinentName AS 'Continent', CurrencyName AS 'Currency' FROM Country WHERE CountryCapital IS NULL";

            query += subquery;

            query += @" UNION SELECT Country.CountryName AS 'Name', Country.CountryArea AS 'Area', 
                                Country.CountryPopulation AS 'Population', Country.CountryGovernment AS 'Government', Country.CountryGDP AS 'GDP', 
                                Country.CountryLeader AS 'Leader', City.CityName AS 'Capital', Country.ContinentName AS 'Continent', Country.CurrencyName AS 'Currency' 
                                FROM Country, City WHERE Country.CountryCapital=City.CityId";
            query += subquery;

            CountriesTable.DataSource = SQLEditor.DoSqlOperation(query);
        }

        private void CheckUser()
        {
            if (user != null)
            {
                if (User.GetUserData(user) != "")
                {
                    StatisticsMenu.Visible = true;
                    NewGameMenu.Visible = true;
                    SignInUpMenu.Text = "Sign Out";
                    requestAdminRootsToolStripMenuItem.Visible = true;

                    if (User.GetUserData(user) == "Requested")
                        requestAdminRootsToolStripMenuItem.Enabled = false;

                    if (User.GetUserData(user) == "Yes")
                    {
                        AdminMenu.Visible = true;
                        EditCountryMenu.Visible = true;
                        SQLEditorMenu.Visible = true;
                        requestAdminRootsToolStripMenuItem.Visible = false;
                    }
                }
            }
        }
    }
}
