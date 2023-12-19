using Harry_Potter.Entity;
using Harry_Potter.Items;
using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets;
using Harry_Potter.Items.Wands;

namespace Harry_Potter.Places;

public class Store
{

    public List<Pet> Pets = new()
    {
        new Cat(Item_Type.Pet, 15, Coinage.GoldGalleon, null, 1, Pet_List.Cat,CatBreed.ForestCat, FurColor.Gray,FurLength.Long,FurPatterns.Tabby,FurQuality.Double),
        new Owl(Item_Type.Pet, 12, Coinage.GoldGalleon, null, 1,Pet_List.Owl, OwlSpecies.Barn_owl),
        new Rat(Item_Type.Pet, 5, Coinage.GoldGalleon, null, 1, Pet_List.Rat, FurColor.Gray),
    };
    public List<Wand> Wands = new()
    {
        new Wand(Item_Type.Wand, 7,Coinage.GoldGalleon, WandWood.Vine, WandCore.Dragon_heartstring, 10.75, WandFlex.Slightly_yielding),
        new Wand(Item_Type.Wand,7,Coinage.GoldGalleon,WandWood.Ash,WandCore.Dittany_Stalk, 10, WandFlex.Slightly_springy),
    };

    public List<SpellBook> Books = new();

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

    public void Shop(Store store, Character harry)
    {
        Console.Clear();
        bool control = true;
        while (control)
        {
            Console.Clear();
            Console.WriteLine($"\nYou are standing inside the store. What would you like to browse?\n" +
                              $"Command List:\nP - Look at pets\nW - Look at wands\nB - Look at books\nX - Leave the store.");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out _))
            {
                switch (input)
                {
                    case "P":
                        BuyPet(store, harry);
                        break;
                    case "W":
                        BuyWand(store, harry);
                        break;
                    case "B":
                        BuyBook(store, harry);
                        break;
                    case "X":
                        Console.WriteLine("You left the store.");
                        Game.Enter(store, harry);
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        Thread.Sleep(2000);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid command");
                Thread.Sleep(2000);
            }


        }

    }

    internal void BuyPet(Store store, Character harry)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("You have chosen to look at pets.\n");
            store.ShowPets();
            Console.WriteLine("would you like to purchase one of our pets?\n If you do, please Type a number that corresponds to the pets place in the list.\n'X' - EXIT.");
            var input2 = Console.ReadLine();

            switch (input2)
            {
                case "X":
                    Shop(store, harry);
                    break;
                default:
                    if (input2 != null)
                    {

                        if (int.TryParse(input2, out _))
                        {
                            int numInt = Convert.ToInt32(input2);

                            if (numInt <= store.Pets.Count && numInt is >= 0)
                            {
                                store.Pets[numInt - 1].PrintInfo();
                                harry.MyPurse.Balance();
                                if (harry.MyPurse.Gold >= store.Pets[numInt - 1].Price)
                                {
                                    Console.WriteLine("You can afford it");
                                    harry.Inventory.Pets.Add(store.Pets[numInt - 1]);
                                    var price = store.Pets[numInt - 1].Price;
                                    if (price != null)
                                        harry.MyPurse.Gold -= price.Value;
                                    harry.MyPurse.Balance();
                                    Console.WriteLine("What would you like to name your new Pet?");
                                    var petName = Console.ReadLine();
                                    harry.Inventory.Pets.Last().Name = petName;
                                    Console.WriteLine(
                                        $"You bougth a {store.Pets[numInt - 1].Type}. List of Pets you own:");
                                    harry.LookAtPets();
                                }
                                else Console.WriteLine("You can't afford to buy it");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid command");
                            Thread.Sleep(2000);
                            BuyPet(store, harry);
                        }

                    }
                    break;
            }




        }
    }

    internal void BuyWand(Store store, Character harry)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("You have chosen to look at wands.\n");
            store.ShowWands();
            Console.WriteLine("Would you like to purchase a wand?\n if so, choose one from the list above by typing the number that corresponds to its place in the list.\n'X' - EXIT");
            var input = Console.ReadLine();
            switch (input)
            {
                case "X":
                    Shop(store, harry);
                    break;
                default:
                    if (input != null)
                    {
                        if (int.TryParse(input, out _))
                        {
                            int numInt = Convert.ToInt32(input);
                            if (numInt <= store.Wands.Count && numInt is >= 0)
                            {
                                store.Wands[0].PrintInfo();
                                harry.MyPurse.Balance();
                                if (harry.MyPurse.Gold >= store.Wands[numInt - 1].Price)
                                {
                                    Console.WriteLine("You can afford it");
                                    harry.Inventory.Wands.Add(store.Wands[numInt - 1]);
                                    var price = store.Wands[numInt - 1].Price;
                                    if (price != null)
                                        harry.MyPurse.Gold -= price.Value;
                                    harry.MyPurse.Balance();
                                    Console.WriteLine(
                                        $"You bought a {store.Wands[numInt - 1].Type}. List of Wands you own:");
                                    harry.LookAtWands();
                                }
                                else Console.WriteLine("You can't afford to buy it");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid command");
                            Thread.Sleep(2000);
                            BuyWand(store, harry);
                        }



                    }
                    break;
            }


        }
    }

    internal void BuyBook(Store store, Character harry)
    {
        Console.Clear();

        Console.WriteLine("Books I own:");
        harry.LookAtBooks();
        while (true)
        {
            Console.WriteLine("You are standing in front of a bookshelf\n");
            Console.WriteLine("\nIf you would like to buy a book,\n press the number that corresponds\n to the books place in the list.\n'X' - EXIT.");
            store.ShowBooks();
            var input = Console.ReadLine();
            switch (input)
            {
                case "X":
                    Shop(store, harry);
                    break;
                default:
                    
                    if (input != null)
                    {
                        if (int.TryParse(input, out _))
                        {
                            int numInt = Convert.ToInt32(input);
                            if (numInt <= store.Books.Count && numInt is > 0)
                            {
                                store.Books[numInt-1].PrintInfo();
                                harry.MyPurse.Balance();
                                if (harry.MyPurse.Gold >= store.Books[numInt - 1].Price)
                                {
                                    Console.WriteLine("You can afford it");
                                    harry.Inventory.SpellBooks.Add(store.Books[numInt - 1]);
                                    var price = store.Books[numInt - 1].Price;
                                    if (price != null)
                                        harry.MyPurse.Gold -= price.Value;
                                    harry.MyPurse.Balance();
                                    Console.WriteLine($"you bought {store.Books[numInt - 1].Title}. List of books you own:");
                                    harry.LookAtBooks();
                                }
                                else Console.WriteLine("You can't afford to buy it");
                            }
                            else
                            {
                                Console.WriteLine($"numInt: {numInt}, store.Books.Count: {store.Books.Count}\n out of range");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid command");
                            Thread.Sleep(2000);
                            BuyBook(store, harry);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        Thread.Sleep(2000);
                        BuyBook(store, harry);
                    }
                    break;
            }


        }


    }
}