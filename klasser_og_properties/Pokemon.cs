using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_og_properties_pokedex
{
    public class Pokemon
    {
        public string Name;
        public int Health { get; set; }
        public int Level { get; set; }
        public Pokemon (string name, int health, int level )
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen");
        }
        public void PrintWelcomeMessage(string Name = "Terje") 
        {
            Console.WriteLine("Hei og velkommen" + Name);
        }
    }
}
