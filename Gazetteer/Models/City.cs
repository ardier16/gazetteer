using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class City : Unit
    {
        public string Latitude { get; } 
        public string Longitude { get; }

        public City(string name, double pop, double area, string lat, string lon)
            : base(name, pop, area)
        {
            this.Latitude = lat;
            this.Longitude = lon;
        }

    }
}
