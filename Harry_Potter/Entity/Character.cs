using Harry_Potter.Items.Money;
using Harry_Potter.Magic;
using Harry_Potter.Places;
using static System.Formats.Asn1.AsnWriter;

namespace Harry_Potter.Entity;

public class Character
{
    private string Name { get; }
    private string Gender { get;}
    private House House { get;}
    public Inventory Inventory { get; set; }

    public Purse MyPurse { get; set; }
    public SpellKnowledge KnownSpells { get; set; }

    public Character(string name, string gender, House house, Inventory inventory, Purse myPurse, SpellKnowledge knownSpells)
    {
        Name = name;
        Gender = gender;
        House = house;
        Inventory = inventory;
        MyPurse = myPurse;
        KnownSpells = knownSpells;
    }

    public void PrintChar()
    {
        Console.WriteLine($"Name: {Name}\nHouse: {House}\nTrunk inventory:");
        foreach (var inventorySpellBook in Inventory.SpellBooks)
        {
            inventorySpellBook.PrintInfo();
        }

        foreach (var wand in Inventory.Wands)
        {
            wand.PrintInfo();
        }
        foreach (var item in Inventory.Pets)
        {
            item.PrintInfo();
        }
    }

    public void LookAtBooks()
    {
        foreach (var book in Inventory.SpellBooks)
        {
            book.PrintInfo();
        }
    }

    public void LookAtWands()
    {
        Console.WriteLine("List of your wands:");
        foreach (var wand in Inventory.Wands)
        {
            wand.PrintInfo();
        }
    }

    public void LookAtPets()
    {
        Console.WriteLine("List of your Pets:");
        foreach (var pet in Inventory.Pets)
        {
            pet.PrintInfo();
        }
    }

    public void ProfilePage()
    {
        Console.Clear();
        Console.WriteLine($"---Name---\n{Name}\n---Gender---\n{Gender}\n---House---\n{House}");
        PrintSpellKnowledge();
        
        Console.WriteLine("X - Exit");
        var input = Console.ReadLine();
        switch (input)
        {
            case "X":
                return;
            default:
                Console.WriteLine("Invalid input");
                Thread.Sleep(3000);
                break;
        }
        
    }
    public void PrintSpellKnowledge()
    {
        Console.WriteLine("List of known Spells:");
        KnownSpells.ShowShort();
    }

    public void Trunk(Store store, Character some)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("'P' - Browse Pets\n'B' - Browse books\n'W' - Browse wands\n'M' - Check Purse\n'X' - to exit inventory");
            var input = Console.ReadLine();
            switch (input)
            {
                case "X":
                    return;
                case "P":
                    BrowsePets(store, some);

                    break;
                case "B":
                    BrowseBooks(store, some);

                    break;
                case "W":
                    BrowseWands(store, some);

                    break;
                case "M":
                    Console.Clear();
                    some.MyPurse.Balance();
                    Console.WriteLine("press any key to return");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Thread.Sleep(3000);
                    break;
            }
        }

    }

    internal void BrowsePets(Store store, Character some)
    {
        some.Inventory.ListPets();
        Console.WriteLine("'B' - Back in Inventory");
        var input = Console.ReadLine();
        switch (input)
        {
            case "B":
                Trunk(store, some);
                break;
            default:
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                BrowsePets(store, some);
                break;
        }

    }

    internal void BrowseBooks(Store store, Character some)
    {
        some.Inventory.ListSpellBooks();
        Console.WriteLine("'R' - Read a book\n'B' - Back in Inventory");
        var input = Console.ReadLine();
        switch (input)
        {
            case "B":
                Trunk(store, some);
                break;
            case "R":
                Hogwarts.ReadABook(store, some);
                break;
            default:
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                BrowseBooks(store, some);
                break;
        }
    }

    internal void BrowseWands(Store store, Character some)
    {
        some.Inventory.ListWands();
        Console.WriteLine("'B' - Back in Inventory");
        var input = Console.ReadLine();
        switch (input)
        {
            case "B":
                Trunk(store, some);
                break;
            default:
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                BrowseWands(store, some);
                break;
        }
    }
}