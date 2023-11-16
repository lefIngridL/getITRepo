using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_og_properties_pokedex
{
    internal class Pokemon
    {
        public int Health { get; set; }
        public int Level { get; set; }
        public Pokemon ( int health, int level )
        {
            Health = health;
            Level = level;
        }
    }
}
