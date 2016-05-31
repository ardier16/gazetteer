using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class Country : Unit
    {
        public string Government { get; }
        public string Capital { get; }
        public List<Region> Regions { get; private set; }
        public List<string> Languages { get; private set; }

        public Country(string name, double pop, double area, string gov, string capital,
                       List<Region> regs, List<string> langs) : base(name, pop, area)
        {
            this.Government = gov;
            this.Capital = capital;
            this.Regions = regs;
            this.Languages = langs;
        }


        // Sum of a population of each region in the country
        public double SummaryRegionsPopulation
        {
            get
            {
                double sumPop = 0;

                for (int i = 0; i < this.Regions.Count; i++)
                {
                    sumPop += this.Regions[i].SummaryCitiesPopulation;
                }

                return sumPop;
            }
            
        }

        // The percentage of the country's urban population
        public double Urbanization
        {
            get { return Math.Round((this.SummaryRegionsPopulation * 100 / 
                this.Population), 3); }
        }

        // Returns information about country in an array 
        // {name, area, population, government, capital}
        public string[] GetInfo()
        {
            return new string[] { Name, Area.ToString(), Population.ToString(),
                Government, Capital };
        }

        // Finds a region that has specified name. 
        // If there's no such of region, method returns null
        public Region SearchRegionByName(string name)
        {
            for (int i = 0; i < Regions.Count; i++)
            {
                if (Regions[i].Name == name)
                    return Regions[i];
            }

            return null;
        }
    }
}
