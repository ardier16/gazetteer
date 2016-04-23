using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class Region : Unit
    {
        public List<City> Cities { get; private set; }
        public string RegionType { get; }
        public string Center { get; }

        public Region(string name, double pop, double area, string type, List<City> cities, string center)
            : base(name, pop, area)
        {
            this.Cities = cities;
            this.RegionType = type;
            this.Center = center;
        }

        public double GetUrbanization()
        {
            return Math.Round((this.GetSummaryCitiesPopulation() * 100 / this.Population), 3);
        }

        public double GetSummaryCitiesPopulation()
        {
            double sumPop = 0;

            for (int i = 0; i < this.Cities.Count; i++)
            {
                sumPop += this.Cities[i].Population;
            }

            return sumPop;
        }

        public void AddCity(City c)
        {
            this.Cities.Add(c);
        }
    }
}
