using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System;

namespace loop_de_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           Oppgave 1: 

            //Lag en for-løkke som printer "Terje er kul" til konsollen 5 ganger

            string statement = "Terje er kul";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(statement + (i + 1));
            }
            //----------------------------------------------------------------------------------------------------

            //Oppgave 2:

            //Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen.
            //Hint: en string kan brukes på samme måte som et array!

            string setning = "Loki season 2 was so great, but so sad!";
            foreach (char rune in setning)
            {
                Console.WriteLine($"{rune}");
            }
            //-----------------------------------------------------------------------------------------------------
            //            Oppgave 3:

            //Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde,
            //så lenge rundetelleren er mindre enn 10

            //Eks:

            //            Runde nr 1

            //Runde nr 2

            //Runde nr 3

            int tell = 0;
            while (tell < 10)
            {
                Console.WriteLine($"Runde nummer: {(tell + 1)}");
                tell++;
            }
            //Console.WriteLine("Hello, World!");

            //        Oppgave: Krokodillespillet
            //Du skal bruke det du har lært til å programmere “krokodille spillet”.

            //For hver runde skal det printes ut til skjermen et random tall mellom 1 - 11,
            //et mellomrom og et nytt tall mellom 1 - 11
            //med en underscore mellom slik at det ser sånn ut: 3 _ 5

            //Brukeren kan skrive inn<, > eller =

            //i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5

            //Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
            //Det må verifiseres om brukeren har valgt riktig alternativ.
            //Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
            //Poengsummen printes til skjermen for hvert svar brukeren har gitt.
            //Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene
            int points = 0;

            bool breaktime = false;
            while (breaktime == false)
            {
                Random rnd = new();
                int raNum = rnd.Next(1, 11);
                Random rnd2 = new();
                int raNum2 = rnd2.Next(1, 11);
                Console.WriteLine($"{raNum}_{raNum2}");
                Console.WriteLine("skriv inn <, > eller =");
                string user = Console.ReadLine();
                
                switch (user)
                {
                    case "<":
                        if (raNum < raNum2)
                        {
                            points++;
                            Console.WriteLine($"Rikig svar! score: {points}");
                        }
                        else
                        {
                            points--;
                            Console.WriteLine($"Feil svar! score: {points}");
                        }
                        break;
                    case ">":
                        if (raNum > raNum2)
                        {
                            points++;
                            Console.WriteLine($"Riktig svar! score: {points}");
                        }
                        else
                        {
                            points--;
                            Console.WriteLine($"Feil svar! score: {points}");
                        }
                        Console.WriteLine();
                        break;
                    case "=":
                        if(raNum == raNum2)
                        {
                            points++;
                            Console.WriteLine($"Riktig svar! score: {points}");

                        }
                        else
                        {
                            points--;
                            Console.WriteLine($"Feil svar! score: {points}");

                        }
                        break;
                    default:
                        breaktime = true;
                        Console.WriteLine($"Feil input, spill slutt...  score: {points}");
                        break;

                }
                Console.WriteLine(user);

                //if(string.IsNullOrWhiteSpace(userInput))
            }

        }
    }
}
