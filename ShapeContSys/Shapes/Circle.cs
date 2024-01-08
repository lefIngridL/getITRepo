using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContSys.Shapes
{
    internal class Circle : Shape
    {
        public double Rad { get; }

        public Circle(string name, string color, double rad) : base(name, color)
        {
            Rad = rad;
        }

        public override double AreaCalc()
        {
            double Area = Math.PI * Rad * Rad;
            return Math.Round(Area, 2);
        }

        public override void PrintShape()
        {
            Console.WriteLine($"navn: {Name}\nFarge: {Color}\nAreal: {AreaCalc()} kvadratcm\n");
        }
    }
}
