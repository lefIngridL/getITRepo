namespace Harry_Potter;

public class Store
{

    public List<Pet> Pets = new List<Pet>
    {
        new Cat(Item_Type.Pet, 15, Coinage.GoldGalleon, null, 1, Pet_List.Cat, CatBreed.ForestCat, FurColor.Gray,FurLength.Long,FurPattern.Tabby,FurQuality.Double),
        new Owl(Item_Type.Pet, 12, Coinage.GoldGalleon, null, 1,Pet_List.Owl, OwlSpecies.Barn_owl),
        new Rat(Item_Type.Pet, 5, Coinage.GoldGalleon, null, 1, Pet_List.Rat, FurColor.Gray),
    };
    public List<Wand> Wands = new List<Wand>
    {
        new Wand(Item_Type.Wand, 7,Coinage.GoldGalleon, WandWood.Vine, WandCore.Dragon_heartstring, 10.75, WandFlex.Slightly_yielding),
        new Wand(Item_Type.Wand,7,Coinage.GoldGalleon,WandWood.Ash,WandCore.Dittany_Stalk, 10, WandFlex.Slightly_springy),
    };

    public List<SpellBook> Books = new List<SpellBook>();

    public Store()
    {

    }

    public void ShowWares()
    {
        Console.WriteLine($"Take a look at my wares:");
        foreach (var pet in Pets)
        {
            pet.PrintInfo();
        }

        foreach (var wand in Wands)
        {
            wand.PrintInfo();
        }
    }

    public void ShowPets()
    {
        Console.WriteLine("Here are the pets on offer:");
        int nr = 1;
        foreach (var pet in Pets)
        {
            Console.WriteLine($"----Nr. {nr}----");
            pet.PrintInfo();
            
            nr++;
        }
    }

    public void ShowWands()
    {
        Console.WriteLine("These are the wands I'm offering:");
        int nr = 1;
        foreach (var wand in Wands)
        {
            Console.WriteLine($"----Nr. {nr}----");
            wand.PrintInfo();
            nr++;
        }
    }

    public void ShowBooks()
    {
        Console.WriteLine("You look at the books on the shelf:");
        int nr = 1;
        foreach (var spellBook in Books)
        {
            Console.WriteLine($"----Nr. {nr}----");
            spellBook.PrintInfo();
            nr++;
        }
    }

    public void Shop(Store Butikk, Character Harry)
    {
        Console.Clear();
        bool control = true;
        while (control)
        {
            //Console.Clear();
            Console.WriteLine($"\nYou are standing inside the store. What would you like to browse?\n" +
                              $"Command List:\nP - Look at pets\nW - Look at wands\nB - Look at books\nX - Leave the store.");
            var input = Console.ReadLine();
            int numInt;
            if (!int.TryParse(input, out numInt))
            {
                switch (input)
                {
                    case "P":
                        Console.WriteLine("You have choosen to look at pets.\n");
                        Butikk.ShowPets();
                        BuyPet(Butikk, Harry);
                        break;
                    case "W":
                        Console.WriteLine("You have choosen to look at wands.\n");
                        //Butikk.ShowWands();
                        BuyWand(Butikk, Harry);
                        break;
                    case "B":
                        Console.WriteLine("You are standing in front of a bookshelf\n");
                        Butikk.ShowBooks();
                        BuyBook(Butikk, Harry);
                        break;
                    case "X":
                        Console.WriteLine("You left the store.");
                        Game.Enter(Butikk, Harry);
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        Thread.Sleep(2000);
                        break;
                }
            }

        }

    }

    internal void BuyPet(Store Butikk, Character Harry)
    {
        Console.Clear();
        bool control2 = true;
        while (true)
        {
            Butikk.ShowPets();
            Console.WriteLine("would you like to purchase one of our pets?\n If you do, please Type a number that corresponds to the pets place in the list.\n'X' - EXIT.");
            var input2 = Console.ReadLine();


            if (input2 != null && input2 != "X")
            {
                int numInt;
                if (int.TryParse(input2, out numInt))
                {
                    numInt = Convert.ToInt32(input2);

                    if (numInt <= Butikk.Pets.Count && numInt.GetType() == (typeof(Int32)) && numInt >= 0)
                    {
                        Butikk.Pets[numInt - 1].PrintInfo();
                        Harry._Purse.Balance();
                        if (Harry._Purse.Gold >= Butikk.Pets[numInt - 1].Price)
                        {
                            Console.WriteLine("You can afford it");
                            Harry._Inventory.Pets.Add(Butikk.Pets[numInt - 1]);
                            Harry._Purse.Gold -= Butikk.Pets[numInt - 1].Price.Value;
                            Harry._Purse.Balance();
                            Console.WriteLine("What would you like to name your new Pet?");
                            var petname = Console.ReadLine();
                            Harry._Inventory.Pets.Last().Name = petname;
                            Console.WriteLine(
                                $"You bougth a {Butikk.Pets[numInt - 1].Type}. List of Pets you own:");
                            Harry.LookAtPets();
                        }
                        else Console.WriteLine("You can't afford to buy it");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Thread.Sleep(2000);
                    BuyPet(Butikk, Harry);
                }

            }
            else if (input2 == "X")
            {
                control2 = false;
                Shop(Butikk, Harry);
            }

        }
    }

    internal void BuyWand(Store Butikk, Character Harry)
    {
        Console.Clear();
        while (true)
        {

            Butikk.ShowWands();
            Console.WriteLine("Would you like to purchase a wand?\n if so, choose one from the list above by typing the number that corresponds to its place in the list.\n'X' - EXIT");
            var input = Console.ReadLine();
            if (input != null && input != "X")
            {
                int numInt;
                if (int.TryParse(input, out numInt))
                {
                    numInt = Convert.ToInt32(input);
                    if (numInt <= Butikk.Wands.Count && numInt.GetType() == (typeof(Int32)) && numInt >= 0)
                    {
                        Butikk.Wands[0].PrintInfo();
                        Harry._Purse.Balance();
                        if (Harry._Purse.Gold >= Butikk.Wands[numInt - 1].Price)
                        {
                            Console.WriteLine("You can afford it");
                            Harry._Inventory.Wands.Add(Butikk.Wands[numInt - 1]);
                            Harry._Purse.Gold -= Butikk.Wands[numInt - 1].Price.Value;
                            Harry._Purse.Balance();
                            Console.WriteLine(
                                $"You bougth a {Butikk.Wands[numInt - 1].Type}. List of Wands you own:");
                            Harry.LookAtWands();
                        }
                        else Console.WriteLine("You can't afford to buy it");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Thread.Sleep(2000);
                    BuyWand(Butikk, Harry);
                }



            }
            else if (input == "X") Shop(Butikk, Harry);
        }
    }

   internal void BuyBook(Store Butikk, Character Harry)
    {
        Console.Clear();
        Console.WriteLine("Books I own:");
        Harry.LookAtBooks();
        while (true)
        {
        Console.WriteLine("\nIf you would like to buy a book,\n press the number that corresponds\n to the books place in the list.\n'X' - EXIT.");
        Butikk.ShowBooks();
        var input = Console.ReadLine();
        if (input != null && input != "X")
        {
            int numInt;
            if (int.TryParse(input, out numInt))
            {
                numInt = Convert.ToInt32(input);
                if (numInt <= Butikk.Books.Count && numInt.GetType() == (typeof(Int32)) && numInt >= 0)
                {
                    Butikk.Books[numInt].PrintInfo();
                    Harry._Purse.Balance();
                    if (Harry._Purse.Gold >= Butikk.Books[numInt-1].Price)
                    {
                        Console.WriteLine("You can afford it");
                        Harry._Inventory.SpellBooks.Add(Butikk.Books[numInt-1]);
                        Harry._Purse.Gold -= Butikk.Books[numInt - 1].Price.Value;
                        Harry._Purse.Balance();
                        Console.WriteLine($"you bought {Butikk.Books[numInt-1]}. List of books you own:");
                        Harry.LookAtBooks();
                    }
                    else Console.WriteLine("You can't afford to buy it");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Thread.Sleep(2000);
                BuyBook(Butikk, Harry);
            }
        }
        else if (input == "X") Shop(Butikk, Harry);
        }


    }
}