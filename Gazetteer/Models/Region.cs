using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class Region : Unit
    {
        public List<City> Cities { get; private set; }
        public string RegionType { get; }
        public string Center { get; }

        public Region(string name, double pop, double area, string type, 
            List<City> cities, string center)
            : base(name, pop, area)
        {
            this.Cities = cities;
            this.RegionType = type;
            this.Center = center;
        }

        // The percentage of the region's urban population
        public double Urbanization
        {
            get { return Math.Round((this.SummaryCitiesPopulation * 100 / this.Population), 3); }
        }

        // Sum of a population of each city in the region
        public double SummaryCitiesPopulation
        {
            get
            {
                double sumPop = 0;

                for (int i = 0; i < this.Cities.Count; i++)
                {
                    sumPop += this.Cities[i].Population;
                }

                return sumPop;
            }
            
        }
    }
}
