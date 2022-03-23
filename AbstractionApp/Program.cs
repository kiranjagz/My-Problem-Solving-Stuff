using AbstractionApp.Database;
using AbstractionApp.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Circle(2),
                new Square(5, 5),
                new Rectangle(5, 10)
            };

            shapes.ForEach(x =>
            {
                var type = x.GetType().Name;
                var area = x.Area();
                Console.WriteLine($"Shape: {type} has an area of: {area.ToString()}");
            });

            var databases = new List<IDatabase>
            {
                new Circle(2),
                new Square(2, 4)
            };

            databases.ForEach(y =>
            {
                y.Add();
            });

            Console.ReadLine();
        }
    }
}
