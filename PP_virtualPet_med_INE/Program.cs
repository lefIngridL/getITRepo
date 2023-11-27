namespace PP_virtualPet_med_INE
{
    internal class Program
    {
        static void Main()
        {
            Choose();
            Start();
            
        }



        static Pet Fido = new Pet("Fido", 5, "Dog");
        private static Pet Larry = new Pet("Larry", 1, "Gecko");
        static Random rand = new Random();
        public static string wichPet = Console.ReadLine 
        public static int PeeAmeter = rand.Next(5, 11);
        public static int Cuddle_O_Meter = rand.Next(5, 11);
        public static int SnackBar = rand.Next(5, 11);

        public static int SpeedOfPee = 3;
        public static int SpeedOfCuddle = 3;
        public static int SpeedOfSnack = 3;

        public static int rounds = 0;
        private static string barDef = "░";
        private static string barprog = "▓";

        public static string[] progress = new string[]
        {
            "[░░░░░░░░░░]", "[▓░░░░░░░░░]", "[▓▓░░░░░░░░]", "[▓▓▓░░░░░░░]", "[▓▓▓▓░░░░░░]", "[▓▓▓▓▓░░░░░]",
            "[▓▓▓▓▓▓░░░░]", "[▓▓▓▓▓▓▓░░░]", "[▓▓▓▓▓▓▓▓░░]", "[▓▓▓▓▓▓▓▓▓░]", "[▓▓▓▓▓▓▓▓▓▓]"
        };


    private static void Start()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine(rounds);
                if (SnackBar >= 1) Console.WriteLine($"{progress[SnackBar - 1]} Snackbar");
                else Console.WriteLine(progress[0] + "Snackbar");
                if (Cuddle_O_Meter >= 1) Console.WriteLine($"{progress[Cuddle_O_Meter - 1]} Cuddle_O_Meter");
                else Console.WriteLine(progress[0] + "Cuddle_O_Meter");
                if (PeeAmeter >= 1) Console.WriteLine($"{progress[PeeAmeter-1]} PeeAmeter");
                else Console.WriteLine(progress[0] + "PeeAmeter");
                
                
                

                
                
                switch (AskInt($"Hei\nvil du (1) mate {Fido.Name}\nvil du (2) klappe {Fido.Name}\neller vil du (3) sjekke om {Fido.Name} må på do?"))
                {
                    case 1:
                        if (SnackBar <= 4)
                        {
                            Console.WriteLine($"{Fido.Name} spiste mat");
                            SnackBar = rand.Next(5, 11);
                        }
                        else Console.WriteLine($"{Fido.Name} er ikke sulten");
                        //if (1 == rand.Next(0, 2)) Console.WriteLine($"{Fido.Name} er ikke sulten");
                        //else Console.WriteLine($"{Fido.Name} spiste mat");
                        break;
                    case 2:
                        if (Cuddle_O_Meter <= 4)
                        {
                            Console.WriteLine($"{Fido.Name} er veldig glad");
                            Cuddle_O_Meter = rand.Next(5, 11);
                        }
                        else Console.WriteLine($"{Fido.Name} vil være i fred");
                        //if (1 == rand.Next(0, 2)) Console.WriteLine($"{Fido.Name} vil være i fred");
                        //else Console.WriteLine($"{Fido.Name} er veldig glad");
                        break;
                    case 3:
                        if (PeeAmeter <= 4)
                        {
                            Console.WriteLine($"{Fido.Name} er pissatrengt så vi slepper han ut");
                            PeeAmeter = rand.Next(5, 11);
                        }
                        else Console.WriteLine($"{Fido.Name} må ikke på do");
                        //if (1 == rand.Next(0, 2)) Console.WriteLine();
                        //else Console.WriteLine($"{Fido.Name} må ikke på do");
                        break;
                    default:
                        Console.WriteLine("Invalid commando");
                        Start();
                        break;
                }
                rounds++;
                
                SnackBar -= rand.Next(0, SpeedOfSnack); 
                Cuddle_O_Meter -= rand.Next(0, SpeedOfCuddle);
                PeeAmeter -= rand.Next(0, SpeedOfPee);
                if (SnackBar < 0)
                {
                    Console.WriteLine($"{Fido.Name} har spiste av søppelen (sulten)");
                    Console.WriteLine($"{Fido.Name} har blitt dårlig i magen og må mer på do");
                    SpeedOfPee = 5;
                    rounds = 0;
                }

                if (Cuddle_O_Meter < 0)
                {
                    Console.WriteLine($"{Fido.Name} ville ikke se på deg engang (kjærlighet)");
                    if (SpeedOfCuddle == 5) SpeedOfCuddle++;
                    else SpeedOfCuddle = 5;
                    rounds = 0;
                }
                if (PeeAmeter < 0)
                {
                    Console.WriteLine($"{Fido.Name} har pisset på gulvet (pissatrengt)");
                    Console.WriteLine($"{Fido.Name} sitt humør har gått ned");
                    if (SpeedOfCuddle == 5) SpeedOfCuddle++;
                    else SpeedOfCuddle = 5;
                    PeeAmeter = rand.Next(3, 5);
                    Cuddle_O_Meter -= rand.Next(2, 5);
                    rounds = 0;
                }
                if (rounds >= 10)
                {
                    SpeedOfPee = 3;
                    SpeedOfCuddle = 3;
                    SpeedOfSnack = 3;
                }
                Thread.Sleep(2500);
            }


        }


        public static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public static int AskInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }
    }
}