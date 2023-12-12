using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContSys
{
    internal class Triangle : Shape
    {

        public int Base { get; }
        public int Height { get; }
        public Triangle(string name, string color, int _base, int heigth) : base(name, color)
        {
            Base = _base;
            Height = heigth;
        }

        public override decimal AreaCalc()
        {
            decimal Area = (decimal)0.5 *((decimal)Base * (decimal)Height);
            return Area;
        }
    }
}
