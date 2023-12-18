namespace Harry_Potter;

public static class Game
{
    public static void Enter(Store Butikk, Character Harry)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\nYou are standing in front of a store in Diagon Alley.\n" +
                              $"Command List:\n'A' - Enter the store\n'X' - Stay on the street.\n'H' - Travel to Hogwarts");
            var input = Console.ReadLine();

            switch (input)
            {
                case "A":
                    Butikk.Shop(Butikk, Harry);
                    break;

                case "X":
                    Console.WriteLine("You are standing in Diagon Alley");
                    break;
                case "H":
                    Hogwarts.AtHogwarts(Butikk, Harry);
                    break;

            }
        }
    }


}