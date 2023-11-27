using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    internal class Vehicle
    {
        internal int weight { get; set; }
        internal int maxSpeed { get; set; }

        public Vehicle(int weight, int maxSpeed)
        {
            this.weight = weight;
            this.maxSpeed = maxSpeed;
        }
    }
}
