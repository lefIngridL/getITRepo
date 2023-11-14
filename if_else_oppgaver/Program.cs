using System;

namespace if_else_oppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i < args.Length; i++)
            {
                string value = args[i];
                Console.WriteLine($"args[{i}] = \"{value}\"");
            }
            //Oppgave 1
            eval();
            static bool eval()
            {
            Console.WriteLine("Skriv et heltall");
            var guess1 = Console.ReadLine();
            int nr1 = int.Parse(guess1);
            Console.WriteLine("Skriv et heltall");
            var guess2 = Console.ReadLine();
            int nr2 = int.Parse(guess2);
            

                if (nr1 == nr2) {
                    Console.WriteLine("yes");
                    return true; }
                else { Console.WriteLine("no");
                    return false;
                }
            }

            //Oppgave 2

            static int doMath()
            {
                Console.WriteLine("Skriv et heltall");
                var guess1 = Console.ReadLine();
                int nr1 = int.Parse(guess1);
                Console.WriteLine("Skriv et heltall");
                var guess2 = Console.ReadLine();
                int nr2 = int.Parse(guess2);

                if (nr1 == nr2) { int product = nr1 * nr2; return product; }
                else { int sum = nr1 + nr2; return sum; }
            }
            Console.WriteLine(doMath());

            Console.WriteLine("Skriv et heltall");
            var guess1 = Console.ReadLine();
            int tall1 = int.Parse(guess1);
            Console.WriteLine("Skriv et heltall");
            var guess2 = Console.ReadLine();
            int tall2 = int.Parse(guess2);
            Console.WriteLine(isitThirty(tall1, tall2));
            static bool isitThirty(int nr1, int nr2) { 
                if(nr1 == 30 || nr2 == 30 || (nr1+ nr2) == 30) { return true; } else { return false; }
            }
            //Console.WriteLine("Hello, World!");
            //int nr1 = 3; int nr2 = 5;

            //bool ans = Boolean(nr1 == nr2);
        }
    }
}

//Oppgaver om conditions - if/else
//Oppgave 1: 

//Lag en metode som tar imot to tall og returnerer true dersom tallene er like. 

//--------------------------------------------------------------------------------------

//Oppgave 2: 
//Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike,
//og returnerer tallene multiplisert med hverandre dersom de er like

//--------------------------------------------------------------------------------------
//Oppgave 3:
//Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
//skal metoden returnere true. Ellers returnerer metoden false