using Harry_Potter.Entity;
using Harry_Potter.Items;
using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets;
using Harry_Potter.Items.Pets.PetNames;
using Harry_Potter.Items.Pets.Cats;
using Harry_Potter.Items.Pets.Cats.CatFur;
using Harry_Potter.Items.Wands;
using System;
using System.Data;

namespace Harry_Potter.Places;

public class Store
{

    public List<Pet> Pets = new()
    {
        GenPet(),
        GenPet(),
        GenPet(),
        GenPet(),
        GenPet(),
    };
    public List<Wand> Wands = new()
    {
        
        GenWand(),
        GenWand(),
        GenWand(),
        GenWand(),
        GenWand(),
        GenWand(),

    };

    public List<SpellBook> Books = new();

    public Store()
    {

    }

    public void ShowWares()
    {
        Console.WriteLine("Take a look at my wares:");
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
                              $"Command List:\n-P - Look at pets\n-W - Look at wands\n-B - Look at books\n-I - Open inventory\n-X - Leave the store.");
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
                    case "I":
                        harry.Trunk(store, harry);
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
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You have chosen to look at pets.\n");
            store.ShowPets();
            Console.WriteLine("would you like to purchase one of our pets?\n\nCommands:\n-Pick a Nr from the list - Buy a Pet.\n-IP - Look at Pets you own.\n-X - EXIT.");
            var input2 = Console.ReadLine();

            switch (input2)
            {
                case "X":
                    Shop(store, harry);
                    break;
                case "IP":
                    Console.Clear();
                    Console.WriteLine("Pets I own:");
                    harry.LookAtPets();
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    BuyPet(store, harry);
                    break;
                default:
                    Console.Clear();
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
                                    Console.WriteLine("\nYou can afford it.\n");
                                    Console.WriteLine("Complete purchase?\n\n-Options:\n-X - exit\n-Any other key - Continue");
                                    var buy = Console.ReadLine();
                                    switch (buy)
                                    {
                                        case "X":
                                            break;
                                        default:
                                            Console.Clear();
                                            harry.Inventory.Pets.Add(store.Pets[numInt - 1]);
                                            var replacePet = GenPet();
                                            store.Pets[numInt - 1] = replacePet;
                                            var price = store.Pets[numInt - 1].Price;
                                            if (price != null)
                                                harry.MyPurse.Gold -= price.Value;
                                            harry.MyPurse.Balance();
                                            Console.WriteLine("What would you like to name your new Pet?");
                                            var petName = Console.ReadLine();
                                            harry.Inventory.Pets.Last().Name = petName;

                                            Console.WriteLine(
                                                $"\nYou bought a \n---{store.Pets[numInt - 1].Type}---\n\n List of Pets you own:");
                                            harry.LookAtPets();
                                            Console.WriteLine("Press any key to continue");
                                            Console.ReadKey();
                                            break;
                                    }

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

    public void randWand()
    {
        while (true)
        {
            Wand wand = GenWand();
            wand.PrintInfo();
            Console.ReadKey();
        }
    }

    internal static Wand GenWand()
    {
        var rand = new Random();
        int likely = rand.Next(0, 1000);
        int rarity;
        if (likely <= 5)
        {
            rarity = 0;
        }
        else if (likely is > 5 and < 995)
        {
            rarity = 1;
        }
        else { rarity = 2; }
        int wood = rand.Next(0, 50);
        int flex = rand.Next(0, 19);
        int core = rand.Next(0, 21);
        double length;
        WandWood Wood = (WandWood)wood;
        WandFlex Flex = (WandFlex)flex;
        WandCore Core = (WandCore)core;
        Wand wand = null;
        switch (rarity)
        {
            case 0:
                length = Math.Round(rand.NextDouble() * 2 + 7, rand.Next(0, 3), MidpointRounding.AwayFromZero);
                wand = new Wand(7, Coinage.GoldGalleon, Wood, Core, length, Flex);
                break;
            case 1:
                length = Math.Round(rand.NextDouble() * 5 + 9, rand.Next(0, 3), MidpointRounding.AwayFromZero);
                wand = new Wand(7, Coinage.GoldGalleon, Wood, Core, length, Flex);
                break;
            case 2:
                length = Math.Round(rand.NextDouble() * 2 + 14, rand.Next(0, 3), MidpointRounding.AwayFromZero);
                wand = new Wand(7, Coinage.GoldGalleon, Wood, Core, length, Flex);
                break;
        }

        return wand;
    }
    internal static Pet GenPet()
    {
        var rand = new Random();
        int index = rand.Next(1, 4);
        Pet Gerald = null;
        switch (index)
        {
            case 1:
                Gerald = GenCat();
                break;
            case 2:
                Gerald = GenOwl();
                break;
            case 3:
                Gerald = GenRat();
                break;
        }
        return Gerald;
    }

    internal static Cat GenCat()
    {
        var rand = new Random();
        int index = rand.Next(1, 6);
        int name = rand.Next(0, 20);
        CatNames catName = (CatNames)name;
        string catNameStr = catName.ToString();
        Cat kitty = null;
        switch (index)
        {
            case 1:
                int color3 = rand.Next(0, 6);
                FurColor furColor3 = (FurColor)color3;
                kitty = new KneazleCat(30, Coinage.GoldGalleon, catNameStr, rand.Next(0, 35), furColor3);
                break;
            case 2:
                int color2 = rand.Next(0, 6);
                FurColor furColor2 = (FurColor)color2;
                kitty = new PersianCat(20, Coinage.GoldGalleon, catNameStr, rand.Next(0, 20), furColor2);
                break;
            case 3:
                int color0 = rand.Next(0, 6);
                FurColor furColor0 = (FurColor)color0;
                kitty = new SiameseCat(15, Coinage.GoldGalleon, catNameStr, rand.Next(0, 20), furColor0);
                break;
            case 4:
                int color1 = rand.Next(0, 6);
                FurColor furColor1 = (FurColor)color1;
                int pattern1 = rand.Next(0, 3);
                FurPatterns furPatterns1 = (FurPatterns)pattern1;

                kitty = new ForestCat(10, Coinage.GoldGalleon, catNameStr, rand.Next(0, 20), furColor1, furPatterns1);
                break;
            case 5:
                int color = rand.Next(0, 6);
                FurColor furColor = (FurColor)color;
                int length = rand.Next(0, 2);
                FurLength furLength = (FurLength)length;
                int pattern = rand.Next(0, 4);
                FurPatterns furPatterns = (FurPatterns)pattern;
                int quality = rand.Next(0, 9);
                FurQuality furQuality = (FurQuality)quality;

                kitty = new Cat(8, Coinage.GoldGalleon, catNameStr, rand.Next(0, 20), furColor, furLength, furPatterns,
                    furQuality);
                break;
        }
        return kitty;
    }

    internal static Owl GenOwl()
    {
        var rand = new Random();
        int index = rand.Next(0, 14);
        int name = rand.Next(0, 20);
        OwlSpecies owlSpecies = (OwlSpecies)index;
        OwlNames owlName = (OwlNames)name;
        string owlNameStr = owlName.ToString();
        var bird = new Owl(15, Coinage.GoldGalleon, owlNameStr, rand.Next(0, 11), owlSpecies);
        return bird;
    }

    internal static Rat GenRat()
    {
        var rand = new Random();
        int color = rand.Next(0, 6);
        int name = rand.Next(0, 10);
        FurColor furColor = (FurColor)color;
        RatNames ratName = (RatNames)name;
        string ratNameStr = ratName.ToString();
        var mousy = new Rat(5, Coinage.SilverSickle, ratNameStr, rand.Next(0, 5), furColor);
        return mousy;
    }

    internal void BuyWand(Store store, Character harry)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("You have chosen to look at wands.\n");
            store.ShowWands();
            Console.WriteLine("Would you like to purchase a wand?\ncommands:\n-Pick a Nr from the list - Buy a Wand.\n-IW - Look at wands you own.\n-X - EXIT\n");
            var input = Console.ReadLine();
            switch (input)
            {
                case "X":
                    Shop(store, harry);
                    break;
                case "IW":
                    Console.Clear();
                    Console.WriteLine("Wands I own:");
                    harry.LookAtWands();
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    BuyWand(store, harry);
                    break;
                default:
                    Console.Clear();
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
                                    Console.WriteLine("You can afford it.\n");
                                    Console.WriteLine("Complete purchase?\n\n-Options:\n-X - exit\n-Any other key - Continue");
                                    var buy = Console.ReadLine();
                                    switch (buy)
                                    {
                                        case "X":
                                            break;
                                        default:
                                            Console.Clear();
                                            harry.Inventory.Wands.Add(store.Wands[numInt - 1]);
                                            var price = store.Wands[numInt - 1].Price;
                                            if (price != null)
                                                harry.MyPurse.Gold -= price.Value;
                                            harry.MyPurse.Balance();
                                            Console.WriteLine(
                                                $"\nYou bought a \n---{store.Wands[numInt - 1]._type}---\n\n List of Wands you own:\n");
                                            harry.LookAtWands();
                                            Console.WriteLine("\n\npress any key to continue");
                                            Console.ReadKey();
                                            break;
                                    }

                                }
                                else Console.WriteLine("You can't afford to buy it.\n");
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
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You are standing in front of a bookshelf\n");
            Console.WriteLine("Commands:\n-X - EXIT.\n-IB - Look at books you own.\n-Pick a Nr from the list - Buy a Spell Book.\n");
            store.ShowBooks();
            var input = Console.ReadLine();
            switch (input)
            {
                case "X":
                    Shop(store, harry);
                    break;
                case "IB":
                    Console.Clear();
                    Console.WriteLine("Books I own:");
                    harry.LookAtBooks();
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    BuyBook(store, harry);
                    break;
                default:
                    Console.Clear();
                    if (input != null)
                    {
                        if (int.TryParse(input, out _))
                        {
                            int numInt = Convert.ToInt32(input);
                            if (numInt <= store.Books.Count && numInt is > 0)
                            {
                                store.Books[numInt - 1].PrintInfo();
                                harry.MyPurse.Balance();
                                if (harry.MyPurse.Gold >= store.Books[numInt - 1].Price)
                                {
                                    Console.WriteLine("You can afford it.\n");
                                    Console.WriteLine("Complete purchase?\n\n-Options:\n-X - exit\n-Any other key - Continue");
                                    var buy = Console.ReadLine();
                                    switch (buy)
                                    {
                                        case "X":
                                            break;
                                        default:
                                            Console.Clear();
                                            harry.Inventory.SpellBooks.Add(store.Books[numInt - 1]);
                                            var price = store.Books[numInt - 1].Price;
                                            if (price != null)
                                                harry.MyPurse.Gold -= price.Value;
                                            harry.MyPurse.Balance();
                                            Console.WriteLine($"\nyou bought:\n---{store.Books[numInt - 1].Title}---\n\nList of books you own:");
                                            harry.LookAtBooks();
                                            Console.WriteLine("\npress any key to continue");
                                            Console.ReadKey();
                                            break;
                                    }

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