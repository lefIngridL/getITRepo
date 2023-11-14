using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace Switch_oppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Oppgave 1: 

            //Ha en variabel med datatypen int og gi den en value med et tall mellom1 og 7.
            //Bruk en switch for å finne ut hvilken dag i uken det tallet er,
            //og print ut dagen med Console.WriteLine();
            //            Eksempel:
            //
            //
            //       1 er mandag, 2 er tirsdag, osv. 
            //
            //Oppgave 2: 

            //Ta utgangspunkt fra oppgave 1,
            //men istedenfor å bruke en int med en fastsatt value,
            //bruker du Console.ReadLine() for at man kan skrive inn et tall i konsollen.
            //Hvis man ikke får inn et tall, skal switch-en kjøre programmet på nytt. 

            bool nono;
            string weekday = string.Empty;
            do
            {
                int variable = 0;
                string userinput;
                static string UserInput()
                {
                    Console.WriteLine("oppgi et tall 1-7");
                    string userinput = Console.ReadLine();
                    return userinput;
                }

                if (!int.TryParse(UserInput(), out variable))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }

                switch (variable)
                {
                    case 1:
                        weekday = "Mandag";
                        nono = true;
                        break;
                    case 2:
                        weekday = "Tirsdag";
                        nono = true;
                        break;
                    case 3:
                        weekday = "Onsdag";
                        nono = true;
                        break;
                    case 4:
                        weekday = "Torsdag";
                        nono = true;
                        break;
                    case 5:
                        weekday = "Fredag";
                        nono = true;
                        break;
                    case 6:
                        weekday = "Lørdag";
                        nono = true;
                        break;
                    case 7:
                        weekday = "Søndag";
                        nono = true;
                        break;
                    default:
                        nono = false;
                        weekday = "Invalid input. Please enter a number between 1 and 7.";
                        Console.WriteLine($"{weekday}");
                        break;
                }
                Console.WriteLine($"Tallet {variable} er {weekday}");
            } while (nono == false);


        }
        //var weekday = variable switch
        //{
        //1 => "Mandag",
        //2 => "Tirsdag",
        //3 => "Onsdag",
        //4 => "Torsdag",
        //5 => "Fredag",
        //6 => "Lørdag",
        //7 => "Søndag",
        //_ =>{break; }
        //};
        //Console.WriteLine($"dagen {variable} er {weekday}");
        //----------------------------------------------------------------

       

    }
}
