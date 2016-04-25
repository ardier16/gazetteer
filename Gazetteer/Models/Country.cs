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

        public double GetSummaryRegionsPopulation()
        {
            double sumPop = 0;

            for (int i = 0; i < this.Regions.Count; i++)
            {
                sumPop += this.Regions[i].GetSummaryCitiesPopulation();
            }

            return sumPop;
        }

        public double GetUrbanization()
        {
            return Math.Round((this.GetSummaryRegionsPopulation() * 100 / this.Population), 3);
        }

        public void AddRegion(Region r)
        {
            this.Regions.Add(r);
        }

        public string[] GetInfo()
        {
            return new string[] { Name, Area.ToString(), Population.ToString(), Government, Capital };
        }
    }
}
