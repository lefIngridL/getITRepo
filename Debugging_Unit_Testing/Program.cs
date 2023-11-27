using System;

namespace Debugging_Unit_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppgave 1: 

            var range = 250;

            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i]);
                    }
                }
            }

        }
    }
}
//1.Sett et breakpoint på den første linjen(linje 9)
//og et breakpoint i starten av hver av foreach løkken(linke 16),
//og et breakpoint på linje 23.

//2.Start applikasjonen og trykk F5 når
//programmet stopper på den første linjen. (eller knappene over).

//3.Skriv “Hei på deg” når konsoll vinduet popper opp.
//Hold musepekeren over verdien character og
//skriv ned et notat med hvilken verdi den har når breakpointet treffes. 

//4.Trykk så F10 flere ganger og
//skriv ned de forskjellige verdiene character endres til for hver runde i løkken.
//Sjekk at counts - arrayet blir oppdatert for hver character i teksten.

//5.Finn ut hvilke verdier variablen “i” må ha i for-løkken for at den
//skal treffe breakpointet på linje 23. (trykk F5 når du er i for-løkken isteden for F10).
