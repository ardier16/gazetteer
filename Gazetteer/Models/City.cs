namespace Gazetteer
{
    public class City : Unit
    {
        public string Region { get; }
        public string Latitude { get; } 
        public string Longitude { get; }

        public City(string name, double pop, double area, string reg, string lat, string lon)
            : base(name, pop, area)
        {
            this.Region = reg;
            this.Latitude = lat;
            this.Longitude = lon;
        }

        public int[] GetLongitude()
        {
            int[] lon = new int[4];

            string d = this.Longitude.Split('°')[0];
            string m = this.Longitude.Split('°')[1].Split('′')[0];
            string s = this.Longitude.Split('°')[1].Split('′')[1].Split('″')[0];

            lon[0] = int.Parse(d);
            lon[1] = int.Parse(m);
            lon[2] = int.Parse(s);

            if (this.Longitude.Contains("в. д."))
                lon[3] = 1;
            else
                lon[3] = 0;

            return lon;
        }

        public int[] GetLatitude()
        {
            int[] lat = new int[4];

            string d = this.Latitude.Split('°')[0];
            string m = this.Latitude.Split('°')[1].Split('′')[0];
            string s = this.Latitude.Split('°')[1].Split('′')[1].Split('″')[0];

            lat[0] = int.Parse(d);
            lat[1] = int.Parse(m);
            lat[2] = int.Parse(s);

            if (this.Latitude.Contains("с. ш."))
                lat[3] = 1;
            else
                lat[3] = 0;

            return lat;
        }

    }
}
