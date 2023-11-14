namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            int nr_tries = 0;   
            

            //if (intguess ==  randomNumber) { Console.WriteLine("You Won!"); }
            //else if (intguess > randomNumber) { Console.WriteLine("Too High!"); }
            //else { Console.WriteLine("Too Low!"); 

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
