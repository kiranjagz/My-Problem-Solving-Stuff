using AbstractionApp.Database;
using System;

namespace AbstractionApp.Shapes
{
    public class Square : Shape, IDatabase
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Square()
        {

        }

        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public void Add()
        {
            Console.WriteLine($"Insert into dummy table: {typeof(Square).Name}, {Width}, {Height}");
        }
    }
}
