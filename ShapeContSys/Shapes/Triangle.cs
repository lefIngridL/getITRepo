using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContSys.Shapes
{
    internal class Triangle : Shape
    {

        public double _Base { get; }
        public double _Height { get; }
        public Triangle(string name, string color, double Base, double heigth) : base(name, color)
        {
            _Base = Base;
            _Height = heigth;
        }

        public override double AreaCalc()
        {
            double Area = 0.5 * _Base * _Height;
            return Math.Round(Area, 2);
        }

        public override void PrintShape()
        {
            Console.WriteLine($"navn: {Name}\nFarge: {Color}\nAreal: {AreaCalc()} kvadratcm\n");
        }
    }
}
