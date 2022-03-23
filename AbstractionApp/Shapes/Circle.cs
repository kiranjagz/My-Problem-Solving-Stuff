using AbstractionApp.Database;
using System;

namespace AbstractionApp.Shapes
{
    public class Circle : Shape, IDatabase
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

        public void Add()
        {
            Console.WriteLine($"Insert into dummy table: {typeof(Circle).Name}, {Radius}");
        }
    }
}
