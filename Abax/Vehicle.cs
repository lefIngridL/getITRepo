using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Abax
{
    abstract class Vehicle
    {
        public string Reg_no { get; set; }
        public decimal? Max_Speed { get; }

        public decimal Effect { get; set; }

        public Vehicle_Type? Type { get; set; }


        protected Dictionary<string, string> Enheter = new Dictionary<string, string>
        {
            {nameof(Max_Speed), "km/t" },
            {nameof(Effect), "kw" },
        };
        protected Vehicle(decimal? maxSpeed, string regNo, decimal effect, Vehicle_Type? type)
        {
            Max_Speed = maxSpeed;
            Reg_no = regNo;
            Effect = effect;
            Type = type;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Klasse: {this}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Reg.nr.: {Reg_no}");
            Console.WriteLine($"Effekt: {Effect}kw");
            if (Max_Speed != null) Console.WriteLine($"Maksfart: {Max_Speed}{Enheter[nameof(Max_Speed)]}");


        }

        public abstract void Run(Vehicle vehicle);
    }
}
