using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class Region : Unit
    {
        public List<City> Cities { get; private set; }
        public string RegionType { get; }
        public Country Country { get; }
        public City Center { get; }

        public Region(string name, int pop, double area, string type, List<City> cities, Country country, City center)
            : base(name, pop, area)
        {
            this.Cities = cities;
            this.RegionType = type;
            this.Country = country;
            this.Center = center;
        }

        public double GetUrbanization()
        {
            return Math.Round((double)(this.GetSummaryCitiesPopulation() * 100 / this.Population), 3);
        }

        public int GetSummaryCitiesPopulation()
        {
            int sumPop = 0;

            for (int i = 0; i < this.Cities.Count; i++)
            {
                sumPop += this.Cities[i].Population;
            }

            return sumPop;
        }
    }
}
