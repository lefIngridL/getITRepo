using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContSys.Shapes
{
    internal abstract class Shape
    {

        public string Name { get; set; }
        public string Color { get; set; }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract double AreaCalc();
        public abstract void PrintShape();
    }
}
