using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_jan.ROM;

namespace Code_jan
{

    public class HUS
    {
        public int NrEtasjer { get; set; }
        public Etasje[] Etasjer { get; set; }

        public HUS(int nrEtasjer, Etasje[] etasje)
        {
            NrEtasjer = nrEtasjer;


            Etasjer = new Etasje[nrEtasjer];
            Etasjer = etasje;
        }

        public void PrintHus()
        {
            Console.Clear();
            Console.WriteLine($"Huset har {NrEtasjer} Etasjer, fordelt på følgende måte:\n");
            int i = 1;
            foreach (var etasje in Etasjer)
            {
                Console.WriteLine($"\n-----Rom i {i}. etasje:-----\n");
                etasje.PrintEtasje();
                i++;
            }
        }
    }
}
