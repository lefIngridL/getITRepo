using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContSys.Shapes
{
    internal class Rectangle : Shape
    {


        public double Length { get;  }
        public double Width { get;}

        public Rectangle(string name, string color, double length, double width) : base(name, color)
        {
            Length = length;
            Width = width;
        }

        public override double AreaCalc()
        {
            double Area = Length * Width;
            return Math.Round(Area, 2);
        }

        public override void PrintShape()
        {
            Console.WriteLine($"navn: {Name}\nFarge: {Color}\nAreal: {AreaCalc()} kvadratcm\n");
        }
    }
}
