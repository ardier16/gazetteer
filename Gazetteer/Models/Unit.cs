using System;
using System.Collections.Generic;

namespace Gazetteer
{
    public abstract class Unit
    {
        public string Name { get; }
        public int Population { get; }
        public double Area { get; }

        public Unit(string name, int pop, double area)
        {
            this.Name = name;
            this.Population = pop;
            this.Area = area;
        }

        public double GetDensity
        {
            get { return this.Area / this.Population; }
        }


    }
}
