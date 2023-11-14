namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            int nr_tries = 0;   
            


            while (true) {
                int hemmelig = randomNumber;
                Console.WriteLine("Gjett ett tall (Heltall)");
                var guess = Console.ReadLine();
                int intguess = int.Parse(guess);
                    nr_tries++;
                    if (intguess == hemmelig) { 
                        Console.WriteLine("Du vant!");
                        break;
                    }
                    else if(intguess > hemmelig) { Console.WriteLine("Tallet er for høyt!"); }
                    else { Console.WriteLine("Tallet er for lavt!"); }
    
                }
                Console.WriteLine($"Du brukte {nr_tries} forsøk");
        }
        }
    }
