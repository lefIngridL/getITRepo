using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    internal class Greet
    {

       
        public string message = "Hei og velkommen ";


        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen ");
        }
        public void PrintWelcomeMessage(string Name = "Terje")
        {
            Console.WriteLine(message + Name);
        }
        
    }
}
