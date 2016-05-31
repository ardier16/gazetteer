using System.Collections.Generic;
using System.Linq;

namespace Gazetteer
{
    public class Continent : Unit
    {
        public List<Country> Countries { get; }
        public override double Population
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

        public Continent(string name, double area, List<Country> countries) : base (name, area, 0)
        {
            this.Countries = countries;
        }

        // Finds cities that have (if method is false) or 
        // contain (if method is true) specified name.
        public List<City> SearchCities(string key, bool method)
        {
            if (method)
            {
                return this.Countries.SelectMany(c => c.Regions).
                    SelectMany(r => r.Cities).Where(c => c.Name.ToLower().
                    IndexOf(key.ToLower()) == 0).ToList();
            }
            else
            {
                return this.Countries.SelectMany(c => c.Regions).
                    SelectMany(r => r.Cities).Where(c => c.Name.ToLower().
                    Contains(key.ToLower())).ToList();
            }
        }

        // Finds a country that has specified name. 
        // If there's no such of country, method returns null
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