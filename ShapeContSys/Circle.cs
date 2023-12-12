using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContSys
{
    internal class Circle : Shape
    {
        public decimal Rad { get; set; }

        public Circle(string name, string color, decimal rad ) : base(name, color)
        {
            Rad = rad;
        }

        public override decimal AreaCalc()
        {
            decimal Area = (decimal)Math.PI * ((decimal)Rad * (decimal)Rad);
            return Area;
        }
    }
}
