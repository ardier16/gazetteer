using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class Map : Form
    {
        private static Point Center = new Point(540, 270);
        private int GameNumber = 1;
        private int TotalScore = 0;
        private bool GameStarted;
        private Point ps;
        private bool MouseClicked;
        List<string> CtsIdcs;
        int nowId;
        string userLogin;
        string[,] tries;
        int gameId;
        Stopwatch time;


        public Map(string user)
        {
            userLogin = user;
            InitializeComponent();
        }

        public Map(List<string> idcs, string login)
        {
            CtsIdcs = idcs;
            userLogin = login;
            InitializeComponent();
        }


        private void MapPic_MouseClick(object sender, MouseEventArgs e)
        {
            if (GameStarted)
            {
                MakePoint(e.X, e.Y);
            }
      
        }
     
        private void Map_Load(object sender, EventArgs e)
        {
            if (CtsIdcs != null)
                DelayDraw();
            else
                CtsIdcs = City.GetCitiesIdcs();

            menuStrip1.Visible = userLogin != null;
        }
       
        private void NewGameMenu_Click(object sender, EventArgs e)
        {
            if (GameNumber > 1)
            {
                GameOver();
            }

            CtsIdcs = City.GetCitiesIdcs();
            StartGame();

        }

        private void NextCityBtn_Click(object sender, EventArgs e)
        {
            if (GameStarted && MouseClicked)
            {
                CheckAnswer();
            }

            else if (NextCityBtn.Text == "End Game")
            {
                GameOver();
            }
        }


        public void Draw(List<string> idcs)
        {
            Graphics g = MapPic.CreateGraphics();
            SolidBrush p = new SolidBrush(Color.White);
            Font f = new Font("Arial", 16);

            for (int i = 0; i < idcs.Count; i++)
            {
                List<string> city = City.GetCityByIndex(idcs[i]);
                Point ps = GetCoords(city);

                g.FillRectangle(new SolidBrush(Color.Black), ps.X - 35, ps.Y + 10, city[0].Length * 14, 25);
                g.DrawString(city[0], f, p, new Point(ps.X - 35, ps.Y + 10));
                Image b = Image.FromFile("map1.png");
                g.DrawImage(b, new Point(ps.X - 21, ps.Y - 42));
            }


        }

        public void DelayDraw()
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                Draw(CtsIdcs);
                timer.Dispose();
            }, null, 100, System.Threading.Timeout.Infinite);
        }


        public Point GetCoords(List<string> Cities)
        {
            int[] lon = City.GetLongitude(Cities[1]);
            int[] lat = City.GetLatitude(Cities[2]);

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
            try
            {
                time = new Stopwatch();
                time.Start();
                label6.Visible = false;
                MapPic.Refresh();
                label2.Text = label4.Text = "";
                label3.Text = "Max Score: " + User.GetMaxScore(userLogin);
                NextCityBtn.Visible = true;
                GameStarted = true;
                TotalScore = 0;
                GameNumber = 1;
                tries = new string[10, 4];
                gameId = SQLEditor.SetId("SELECT GameId FROM Game");
                Game.InsertGameData(userLogin);
                NextCity();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void NextCity()
        {
            if (GameNumber > 10 && GameStarted)
            {
                GameStarted = false;
                NextCityBtn.Text = "End Game";
                label1.Text = "";
                GameNumber = 1;
            }

            else
            {
                Random r = new Random();
                CtsIdcs = City.GetCitiesIdcs();
                nowId = r.Next(0, CtsIdcs.Count);
                List<string> city = City.GetCityByIndex(CtsIdcs[nowId].ToString());
                label1.Text = GameNumber++ + ". " + city[0] + ", " +
                    city[3] + ": " + city[4] + ", " +
                    city[5];
            }
        }

        public void MakePoint(int X, int Y)
        {
            MouseClicked = true;
            Graphics g = MapPic.CreateGraphics();
            ps = new Point(X, Y);
            MapPic.Refresh();
            Image b = Image.FromFile("map.png");
            g.DrawImage(b, new Point(ps.X - 21, ps.Y - 42));
        }

        public void CheckAnswer()
        {
            List<string> cts = new List<string>();
            cts.Add(CtsIdcs[nowId].ToString());
            Point p = GetCoords(City.GetCityByIndex(CtsIdcs[nowId].ToString()));
            Draw(cts);
            MouseClicked = false;

            int score = (int)Math.Round(50000 / (GetDistance(ps, p) + 0.1), 2);

            label4.Text = Math.Round(GetDistance(ps, p), 2).ToString() + " km to goal";
            label2.Text = "+" + score.ToString();
            TotalScore += score;
            label5.Text = "Score: " + TotalScore;

            Try.InsertTryResults(score.ToString(), gameId.ToString(), CtsIdcs[nowId].ToString());

            NextCity();
        }

        public void GameOver()
        {
            time.Stop();
            int gameTime = Convert.ToInt32(time.ElapsedMilliseconds / 1000);

            if (TotalScore > User.GetMaxScore(userLogin))
            {
                MessageBox.Show("New Max Score: " + TotalScore);
                label3.Text = "Max Score: " + TotalScore;
                User.UpdateMaxScore(userLogin, TotalScore.ToString());
            }
            else
                MessageBox.Show("Your Score: " + TotalScore);

            NextCityBtn.Text = "Next City";
            NextCityBtn.Visible = false;
            label1.Text = label2.Text = label4.Text = label5.Text = "";
            Game.UpdateGameData(gameId.ToString(), TotalScore.ToString(), gameTime.ToString());
        }      
           
    }
}
