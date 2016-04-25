using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public abstract class Unit
    {
        public string Name { get; }
        public double Population { get; }
        public double Area { get; }

        public Unit(string name, double pop, double area)
        {
            this.Name = name;
            this.Population = pop;
            this.Area = area;
        }

        public double Density
        {
            get { return this.Population / this.Area; }
        }
    }
}
