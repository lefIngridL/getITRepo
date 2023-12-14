namespace Harry_Potter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Book = new SpellBook();
            List<Item> inventory = new List<Item>();
            inventory.Add(new Pet(Item_Type.Pet, null, null, "Hedwig", Pet_List.Owl));
            inventory.Add(new Wand(Item_Type.Wand, null, null, WandWood.Holly, WandCore.Phoenix_feather, 11.5, WandFlex.Supple));
            Character Harry = new Character("Harry Potter", House.Griffindor, inventory, new Purse(100, 50, 25), new SpellKnowledge(Book.Spells));

            Harry.PrintChar();
            foreach (var spell in Harry.KnownSpells.Knowledge)
            {
                spell.PrintSpell();
            }
            

            Store Butikk = new Store();
            Enter(Butikk, Harry);
            Butikk.ShowWares();
        }

        public static void Enter(Store Butikk, Character Harry)
        {
            while (true)
            {
                Console.WriteLine($"\nYou are standing in front of a store.\n Press 'A' to enter the store, or press 'X' to stay on the street.\nTo Practice spells at Hogwarts, press 'H'");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "A":
                        Shop(Butikk, Harry);
                        break;

                    case "X":
                        Console.WriteLine("You are standing in Diagon Alley");
                        break;
                    case "H":
                        Hogwarts(Butikk, Harry);
                        break;
                }
            }



        }

        public static void Shop(Store Butikk, Character Harry)
        {
            while (true)
            {
                Console.WriteLine($"You are standing inside the store. What would you like to browse?\n Press 'P' to look at pets, or press 'W' to look at wands. Press 'X' to Leave the store.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "P":
                        Console.WriteLine("You have choosen to look at pets.\n");
                        Butikk.ShowPets();
                        BuyPet(Butikk, Harry);
                        break;
                    case "W":
                        Console.WriteLine("You have choosen to look at wands.\n");
                        Butikk.ShowWands();
                        BuyWand(Butikk, Harry);
                        break;
                    case "X":
                        Console.WriteLine("You left the store.");
                        Enter(Butikk, Harry);
                        break;
                }
            }

        }

        public static void BuyPet(Store Butikk, Character Harry)
        {
            while (true)
            {
                Console.WriteLine("would you like to purchase one of our pets? If you do, please Type a number that corresponds to the pets place in the list.\n Press 'X' if you do not want to purchase a pet.");
                var input = Console.ReadLine();
                if (input != null && input != "X")
                {
                    switch (input)
                    {
                        case "1":
                            Butikk.Pets[0].PrintInfo();
                            Harry._Purse.Balance();
                            if (Harry._Purse.Gold >= Butikk.Pets[0].Price) Console.WriteLine("You can afford it");
                            else Console.WriteLine("You can't afford to buy it");
                            break;
                        case "2":
                            Butikk.Pets[1].PrintInfo();
                            Harry._Purse.Balance();
                            if (Harry._Purse.Gold >= Butikk.Pets[1].Price) Console.WriteLine("You can afford it");
                            else Console.WriteLine("You can't afford to buy it");
                            break;
                        case "3":
                            Butikk.Pets[2].PrintInfo();
                            Harry._Purse.Balance();
                            if (Harry._Purse.Gold >= Butikk.Pets[2].Price) Console.WriteLine("You can afford it");
                            else Console.WriteLine("You can't afford to buy it");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else if (input == "X") Shop(Butikk, Harry);

            }
        }

        public static void BuyWand(Store Butikk, Character Harry)
        {
            while (true)
            {
                Console.WriteLine("Would you like to purchase a wand?\n if so, choose one from the list above by typing the number that corresponds to its place in the list.\n if you do not wish to purchase, press 'X'");
                var input = Console.ReadLine();
                if (input != null && input != "X")
                {
                    switch (input)
                    {
                        case "1":
                            Butikk.Wands[0].PrintInfo();
                            Harry._Purse.Balance();
                            if (Harry._Purse.Gold >= Butikk.Wands[0].Price) Console.WriteLine("You can afford it");
                            else Console.WriteLine("You can't afford to buy it");
                            break;
                        case "2":
                            Butikk.Wands[1].PrintInfo();
                            Harry._Purse.Balance();
                            if (Harry._Purse.Gold >= Butikk.Wands[1].Price) Console.WriteLine("You can afford it");
                            else Console.WriteLine("You can't afford to buy it");
                            break;
                        case "3":
                            Butikk.Wands[2].PrintInfo();
                            Harry._Purse.Balance();
                            if (Harry._Purse.Gold >= Butikk.Wands[2].Price) Console.WriteLine("You can afford it");
                            else Console.WriteLine("You can't afford to buy it");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else if (input == "X") Shop(Butikk, Harry);
            }
        }

        public static void Hogwarts(Store Butikk, Character Harry)
        {
            while (true)
            {
                Console.WriteLine("You are at Hogwarts school of Witchcraft and Wizardry. Time to practice some spells!\n press 'S' to continue or 'X' to travel back to Diagon Alley.");
                var input = Console.ReadLine();

                if (input != null)
                {
                    switch (input)
                    {
                        case "S":
                            Console.WriteLine("Lets have look at the spellbook!");
                            break;
                        case "X":
                            Enter(Butikk, Harry);
                            break;
                    }
                }
            }

        }
    }
}