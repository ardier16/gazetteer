using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class City : Unit
    {
        public string Latitude { get; } 
        public string Longitude { get; }
        public Region Region { get; }

        public City(string name, int pop, double area, string lat, string lon, Region reg)
            : base(name, pop, area)
        {
            this.Latitude = lat;
            this.Longitude = lon;
            this.Region = reg;
        }

    }
}
