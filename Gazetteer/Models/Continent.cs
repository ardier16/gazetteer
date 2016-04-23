using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public class Continent 
    {
        public string Name { get; }
        public double Area { get; }
        public List<Country> Countries { get; }

        public Continent(string name, double area, List<Country> countries)
        {
            this.Name = name;
            this.Area = area;
            this.Countries = countries;
        }

        public int GetPopulation()
        {
            int pop = 0;

            for (int i = 0; i < this.Countries.Count; i++)
            {
                pop += this.Countries[i].GetSummaryRegionsPopulation();
            }

            return pop;
        }

        public List<City> SearchCitiesHomonyms(string key)
        {
            List<City> CitiesList = new List<City>();

            for (int i = 0; i < this.Countries.Count; i++)
            {
                for (int j = 0; j < this.Countries[i].Regions.Count; j++)
                {
                    for (int k = 0; k < this.Countries[i].Regions[j].Cities.Count; k++)
                    {
                        if (this.Countries[i].Regions[j].Cities[k].Name.ToLower().Contains(key.ToLower()))
                            CitiesList.Add(this.Countries[i].Regions[j].Cities[k]);
                    }
                }
            }

            return CitiesList;
        }
    }
}
