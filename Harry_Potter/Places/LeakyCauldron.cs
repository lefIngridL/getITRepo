using Harry_Potter.Entity;

namespace Harry_Potter.Places;

public static class LeakyCauldron
{
    public static void TomsBar(Store store, Character harry)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You are standing in the Leaky Cauldron.");

            Console.WriteLine("Commandlist:\n\n'Y' - walk towards Diagon Alley\n'T' - Talk to Tom, the barman\n'X' - Enter London\n");
            var input = Console.ReadLine();
            switch (input)
            {
                case "Y":
                    Game.Enter(store, harry);
                    break;
                case "T":
                    TheBar(store, harry);
                    break;
                case "X":
                    MuggleLondon.London(store, harry);
                    break;
            }

        }

    }

    public static void TheBar(Store store, Character harry)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Hello there young traveler! What would you like to do?\n\nCommandlist:\n'Q' - Gossip\n'W' - Buy something from the bar\n'E' - Rent a room for the night\n'R' - Rent a private conference room");
            var input = Console.ReadLine();
            switch (input)
            {
                case "Q":
                    BarGossip(store, harry);
                    break;
                case "W":
                    BarFood(store, harry);
                    break;
                case "E":
                    BarRoom(store, harry);
                    break;
                case "R":
                    BarPrivateRoom(store, harry);
                    break;
            }
        }


    }

    public static void BarGossip(Store store, Character harry)
    {
        Console.Clear();
        Console.WriteLine("Oh? So, you want to know whats going on around here?");
        Console.ReadKey();
    }

    public static void BarFood(Store store, Character harry)
    {
        Console.Clear();
        Console.WriteLine("Lets have a look at todays menu");
        Console.ReadKey();
    }

    public static void BarRoom(Store store, Character harry)
    {
        Console.Clear();
        Console.WriteLine("So, you need a room for the night?");
        Console.ReadKey();
    }

    public static void BarPrivateRoom(Store store, Character harry)
    {
        Console.Clear();
        Console.WriteLine("Ah, so you would like to rent the private parlour?");
        Console.ReadKey();
    }
}