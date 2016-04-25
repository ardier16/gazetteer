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



        public double Population
        {
            get
            {
                double pop = 0;

                for (int i = 0; i < this.Countries.Count; i++)
                {
                    pop += this.Countries[i].Population;
                }

                return pop;
            }
        }



        public List<City> SearchCitiesHomonyms(string key, bool method)
        {
            List<City> CitiesList = new List<City>();

            for (int i = 0; i < this.Countries.Count; i++)
            {
                for (int j = 0; j < this.Countries[i].Regions.Count; j++)
                {
                    for (int k = 0; k < this.Countries[i].Regions[j].Cities.Count; k++)
                    {
                        string name = this.Countries[i].Regions[j].Cities[k].Name.ToLower();

                        if (method)
                        {
                            if (name.IndexOf(key.ToLower()) == 0)
                                CitiesList.Add(this.Countries[i].Regions[j].Cities[k]);
                        }
                        else
                        {
                            if (name.Contains(key.ToLower()))
                                CitiesList.Add(this.Countries[i].Regions[j].Cities[k]);
                        }
                    }
                }
            }

            return CitiesList;
        }

        public void AddCountry(Country c)
        {
            this.Countries.Add(c);
        }

        public Country SearchCountryByName(string name)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (Countries[i].Name == name)
                    return Countries[i];
            }

            return null;
        }

    }
}
