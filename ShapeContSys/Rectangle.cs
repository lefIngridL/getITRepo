using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContSys
{
    internal class Rectangle : Shape
    {
        

        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(string name, string color, int length, int width) : base(name, color)
        {
            Length = length;
            Width = width;
        }

        public override decimal AreaCalc()
        {
            decimal Area = Length * Width;
            return Area;
        }
    }
}
