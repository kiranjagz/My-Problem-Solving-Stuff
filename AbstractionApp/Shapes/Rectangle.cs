using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionApp.Shapes
{
    public class Rectangle : Shape //Did not implement IDatabase here, just to show that saving is not needed.
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;

    }
}
