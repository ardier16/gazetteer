using System;
using System.Data;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class CityEditor : Form
    {
        int regId;
        int cityId;

        public CityEditor(int id)
        {
            regId = id;
            InitializeComponent();
        }

        public CityEditor(int rId, int cId)
        {
            regId = rId;
            cityId = cId;
            InitializeComponent();
        }

        public CityEditor()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCityData();
                MessageBox.Show("Changes Saved!");
                this.Close();

            }
            catch 
            {
                MessageBox.Show("Please, enter correct data!");
                return;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CityEditor_Load(object sender, EventArgs e)
        {
            FillCityData();
        }


        private void FillCityData()
        {
            if (cityId > 0)
            {
                DataTable dt = SQLEditor.DoSqlOperation("SELECT * FROM City WHERE CityId=" + cityId);
                label1.Text = "City";
                NameField.Text = dt.Rows[0].ItemArray[1].ToString();
                AreaField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[4].ToString());
                AreaField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[5].ToString());
                BuildYearField.Value = Convert.ToDecimal(dt.Rows[0].ItemArray[6].ToString());
                LeaderField.Text = dt.Rows[0].ItemArray[7].ToString();

                int[] lon = City.GetLongitude(dt.Rows[0].ItemArray[2].ToString());
                int[] lat = City.GetLatitude(dt.Rows[0].ItemArray[3].ToString());

                LatDegsField.Value = lat[0];
                LatMinsField.Value = lat[1];
                LatSecsField.Value = lat[2];

                LonDegsField.Value = lon[0];
                LonMinsField.Value = lon[1];
                LonSecsField.Value = lon[2];

                if (lon[3] == 0)
                    LonWestChB.Checked = true;
                if (lat[3] == 0)
                    LatSouthChB.Checked = true;
            }
        }

        private void SaveCityData()
        {
            string Cname = NameField.Text;
            int Carea = Convert.ToInt32(AreaField.Value);
            int Cpop = Convert.ToInt32(BuildYearField.Value);
            int year = Convert.ToInt32(BuildYearField.Value);
            string leader = LeaderField.Text;

            string lon = LonDegsField.Value + "°" + LonMinsField.Value + "′" + LonSecsField.Value + '"' + " ";
            string lat = LatDegsField.Value + "°" + LatMinsField.Value + "′" + LatSecsField.Value + '"' + " ";

            if (LonEastChB.Checked)
                lon += "E";
            else
                lon += "W";

            if (LatNorthChB.Checked)
                lat += "N";
            else
                lat += "S";

            if (Cname == "" || Carea <= 0 || Cpop == 0 || leader.Length == 0)
            {
                throw new Exception();
            }

            if (cityId > 0)
                City.UpdateCity(cityId, Cname, lon, lat, Carea, Cpop.ToString(), year, leader, regId);
            else
                City.InsertCity(Cname, lon, lat, Carea, Cpop.ToString(), year, leader, regId);

        }
    }
}
