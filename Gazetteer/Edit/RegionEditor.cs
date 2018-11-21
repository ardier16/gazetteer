using System;
using System.Data;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class RegionEditor : Form
    {
        int regId = -1;
        string country;

        public RegionEditor(string coun)
        {
            country = coun;
            InitializeComponent();
        }

        public RegionEditor(int id)
        {
            regId = id;
            InitializeComponent();
        }


        private void RegionEditor_Load(object sender, EventArgs e)
        {
            FillFormData();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                MessageBox.Show("Changes saved!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please, enter correct data");
            }
        }

        private void type_KeyPress(object sender, KeyPressEventArgs e)
        {
            TypeList.DataSource = SQLEditor.GetList("SELECT RegionType FROM Region WHERE RegionType LIKE '" + TypeList.Text + "%' GROUP BY RegionType ORDER BY Count(*) DESC");
            TypeList.DroppedDown = true;
        }


        private void FillFormData()
        {
            CenterList.DataSource = SQLEditor.GetCurList("SELECT CityName FROM City WHERE RegionId=" + regId);
            TypeList.DataSource = SQLEditor.GetList("SELECT RegionType FROM Region GROUP BY RegionType ORDER BY Count(*) DESC");
            TypeList.Text = "";

            if (regId != -1)
            {

                label1.Text = "Region";
                DataTable dt = SQLEditor.DoSqlOperation("SELECT * FROM Region WHERE RegionId=" + regId);

                NameField.Text = dt.Rows[0].ItemArray[1].ToString();
                AreaField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[2].ToString());
                PopulationField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[3].ToString());
                TypeList.Text = dt.Rows[0].ItemArray[4].ToString();
                LeaderField.Text = dt.Rows[0].ItemArray[6].ToString();
                country = dt.Rows[0].ItemArray[7].ToString();
                CenterList.Text = City.SearchCityById(dt.Rows[0].ItemArray[5].ToString());
            }
        }

        private void SaveData()
        {
            string Rname = NameField.Text;
            decimal Rarea = AreaField.Value;
            decimal Rpop = PopulationField.Value;
            string Rtype = TypeList.Text;
            string Rlead = LeaderField.Text;
            string Rcen = "NULL";

            if (CenterList.Text != "Nope")
                Rcen = City.SearchCityByName(CenterList.Text, country);


            if (Rname == "" || Rtype == "" || Rlead == "")
            {
                throw new Exception();
            }

            if (regId == -1)
                State.InsertRegion(Rname, (int)Rarea, Rpop.ToString(), Rtype, Rcen, Rlead, country);
            else
                State.UpdateRegion(regId, Rname, (int)Rarea, Rpop.ToString(), Rtype, Rcen, Rlead, country);
        }
    }
}
