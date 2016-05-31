namespace Gazetteer
{
    public abstract class Unit
    {
        public string Name { get; }
        public virtual double Population { get; }
        public double Area { get; }

        public Unit(string name, double pop, double area)
        {
            this.Name = name;
            this.Population = pop;
            this.Area = area;
        }


        // Returns population per unit area
        public double Density
        {
            get { return this.Population / this.Area; }
        }
    }
}