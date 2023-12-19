using Harry_Potter.Items.Money;
using Harry_Potter.Magic;

namespace Harry_Potter.Entity;

public class Character
{
    private string Name { get; set; }
    private House House { get; set; }
    public Inventory Inventory { get; set; }

    public Purse MyPurse { get; set; }
    public SpellKnowledge KnownSpells { get; set; }

    public Character(string name, House house, Inventory inventory, Purse myPurse, SpellKnowledge knownSpells)
    {
        Name = name;
        House = house;
        Inventory = inventory;
        MyPurse = myPurse;
        KnownSpells = knownSpells;
    }

    public void PrintChar()
    {
        Console.WriteLine($"Navn: {Name}\nHus: {House}\nInnhold i koffert:");
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

    public void PrintSpellKnowledge()
    {
        Console.WriteLine("List of known Spells:");
        KnownSpells.ShowShort();
    }
}