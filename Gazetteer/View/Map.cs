using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Map : Form
    {
        private Point Center = new Point(540, 270);
        private List<City> cities;
        private List<Continent> conts;
        private City c;
        private int GameNumber = 1;
        private double TotalScore = 0;
        private bool GameStarted;
        private double HighScore;
        private Point ps;
        private bool MouseClicked;

        public Map()
        {
            InitializeComponent();
        }

        public Map(List<City> c)
        {
            this.cities = c;
            InitializeComponent();
        }

        public Map(List<Continent> l)
        {
            this.conts = l;
            InitializeComponent();
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (GameStarted)
            {
                MakePoint(e.X, e.Y);
            }
      
        }
     
        private void Map_Load(object sender, EventArgs e)
        {
            if (conts != null)
            {
                cities = GetCities();
            }
            else if (cities != null)
            {
                DelayDraw();
            }
        }
       
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = File.OpenText("score.txt"))
                {
                    HighScore = double.Parse(sr.ReadLine());
                }
            }
            catch
            {
                HighScore = 0;
            }

            StartGame();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameStarted && MouseClicked)
            {
                CheckAnswer();
            }

            else if (button1.Text == "Конец")
            {
                GameOver();
            }
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

        public void Draw(List<City> cities)
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush p = new SolidBrush(Color.White);
            Font f = new Font("Arial", 16);

            for (int i = 0; i < cities.Count; i++)
            {
                Point ps = GetCoords(cities[i]);

                g.FillRectangle(new SolidBrush(Color.Black), ps.X - 35, ps.Y + 10, cities[i].Name.Length*14, 25);
                g.DrawString(cities[i].Name, f, p, new Point(ps.X - 35, ps.Y + 10));
                Image b = Image.FromFile("map1.png");
                g.DrawImage(b, new Point(ps.X - 21, ps.Y - 42));
            }
            

        }

        public List<City> GetCities()
        {
            List<City> cities = new List<City>();

            for (int i = 0; i < conts.Count; i++)
            {
                for (int j = 0; j < conts[i].Countries.Count; j++)
                {
                    for (int k = 0; k < conts[i].Countries[j].Regions.Count; k++)
                    {
                        cities.AddRange(conts[i].Countries[j].Regions[k].Cities);
                    }
                }
            }

            return cities;
        }

        public void DelayDraw()
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                Draw(cities);
                timer.Dispose();
            },
                        null, 100, System.Threading.Timeout.Infinite);
        }

        public double GetDistance(Point p1, Point p2)
        {
            int dX = Math.Abs(p1.X - p2.X);
            int dY = Math.Abs(p1.Y - p2.Y);

            if (dX > 540)
                dX = 1080 - dX;
            if (dY > 270)
                dY = 540 - dY;

            double dist = Math.Sqrt(dX * dX + dY * dY);

            return 37.1 * dist;
        }

        public void StartGame()
        {
            if (cities.Count > 5)
            {
                label6.Visible = false;
                pictureBox1.Refresh();
                label2.Text = label4.Text = "";
                label3.Text = "Рекорд: " + HighScore;
                button1.Visible = true;
                GameStarted = true;
                TotalScore = 0;
                GameNumber = 1;
                NextCity();
            }
            else
            {
                MessageBox.Show("Слишком мало городов");
            }
        }

        public void NextCity()
        {
            if (GameNumber > 5 && GameStarted)
            {
                GameStarted = false;
                button1.Text = "Конец";
                label1.Text = "";
                GameNumber = 1;
            }

            else
            {
                Random r = new Random();
                c = cities[r.Next(0, cities.Count - 1)];
                label1.Text = GameNumber++ + ". " + c.Name + ", " + c.Region;
            }
        }

        public void MakePoint(int X, int Y)
        {
            MouseClicked = true;
            Graphics g = pictureBox1.CreateGraphics();
            ps = new Point(X, Y);
            pictureBox1.Refresh();
            Image b = Image.FromFile("map.png");
            g.DrawImage(b, new Point(ps.X - 21, ps.Y - 42));
        }

        public void CheckAnswer()
        {
            List<City> cts = new List<City>();
            cts.Add(c);
            Point p = GetCoords(cts[0]);
            Draw(cts);
            MouseClicked = false;

            double score = Math.Round(50000 / (GetDistance(ps, p) + 0.1), 2);

            label4.Text = Math.Round(GetDistance(ps, p), 2).ToString() + " км";
            label2.Text = "+" + score.ToString();
            TotalScore += score;
            label5.Text = "Счёт: " + TotalScore;
            NextCity();
        }

        public void GameOver()
        {
            if (TotalScore > HighScore)
            {
                MessageBox.Show("Новый рекорд: " + TotalScore);
                HighScore = TotalScore;

                try
                {
                    using (StreamWriter wr = File.CreateText("score.txt"))
                    {
                        wr.Write(HighScore);
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка при записи файла");
                }

                label3.Text = "Рекорд: " + HighScore;
            }
            else
                MessageBox.Show("Ваш счёт: " + TotalScore);

            button1.Text = "Далее";
            button1.Visible = false;
            label1.Text = label2.Text = label4.Text = label5.Text = "";
        }             
    }
}
