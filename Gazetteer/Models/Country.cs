using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class Country : Unit
    {
        public string Government { get; }
        public City Capital { get; }
        public List<Region> Regions { get; private set; }
        public string[] Languages { get; private set; }

        public Country(string name, int pop, double area, string gov, City capital,
                       List<Region> regs, string[] langs) : base(name, pop, area)
        {
            this.Government = gov;
            this.Capital = capital;
            this.Regions = regs;
            this.Languages = langs;
        }

        public int GetSummaryRegionsPopulation()
        {
            int sumPop = 0;

            for (int i = 0; i < this.Regions.Count; i++)
            {
                sumPop += this.Regions[i].GetSummaryCitiesPopulation();
            }

            return sumPop;
        }

        public double GetUrbanization()
        {
            return Math.Round((double)(this.GetSummaryRegionsPopulation() * 100 / this.Population), 3);
        }
    }
}
