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
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(statement + (i+1));
            }
            //----------------------------------------------------------------------------------------------------

            //Oppgave 2:

            //Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen.
            //Hint: en string kan brukes på samme måte som et array!

            string setning = "Loki season 2 was so great, but so sad!";
            foreach(char rune in setning)
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
            while( tell < 10 ) {
                Console.WriteLine($"Runde nummer: {(tell + 1)}");
                tell++;
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
