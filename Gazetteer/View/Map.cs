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
    public partial class Map : Form
    {
        public Point Center = new Point(506, 270);
        public List<City> cities;

        public Map()
        {
            InitializeComponent();
        }

        public Map(List<City> c)
        {
            this.cities = c;
            InitializeComponent();
        }

        public Point GetCoords(City city)
        {
            int[] lon = city.GetLongitude();
            int[] lat = city.GetLatitude();

            int Lon = (int)(lon[0] + lon[1] / 60 + lon[2] / 360);
            int Lat = (int)(lat[0] + lat[1] / 60 + lat[2] / 360);

            Point coordinate = new Point(3 * Lon, 3 * Lat);

            if (lon[3] == 1)
                coordinate.X += Center.X;
            else
                coordinate.X = Center.X - coordinate.X;

            if (lat[3] == 1)
                coordinate.Y = Center.Y - coordinate.Y;
            else
                coordinate.Y += Center.Y;
            
            return coordinate;
        }

        public void Draw()
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush p = new SolidBrush(Color.Red);
            Font f = new Font("Arial", 16);
            Pen pe = new Pen(Color.Red);

            for (int i = 0; i < cities.Count; i++)
            {
                Point ps = GetCoords(cities[i]);

                g.DrawString(cities[i].Name, f, p, new Point(ps.X - 35, ps.Y + 10));
                Image b = Image.FromFile("map.png");
                g.DrawImage(b, new Point(ps.X-21, ps.Y-42));
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Map_Activated(object sender, EventArgs e)
        {
            
            DelayDraw();
        }

        public void DelayDraw()
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                Draw();
                timer.Dispose();
            },
                        null, 100, System.Threading.Timeout.Infinite);
        }
    }
}
