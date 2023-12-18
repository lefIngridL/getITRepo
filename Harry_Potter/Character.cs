namespace Harry_Potter;

public class Character
{
    public string Name { get; set; }
    public House House { get; set; }
    public Inventory _Inventory { get; set; }

    public Purse _Purse { get; set; }
    public SpellKnowledge KnownSpells { get; set; }

    public Character(string name, House house, Inventory inventory, Purse purse, SpellKnowledge knownSpells)
    {
        Name = name;
        House = house;
        _Inventory = inventory;
        _Purse = purse;
        KnownSpells = knownSpells;
    }

    public void PrintChar()
    {
        Console.WriteLine($"Navn: {Name}\nHus: {House}\nInnhold i koffert:");
        foreach (var inventorySpellBook in _Inventory.SpellBooks)
        {
            inventorySpellBook.PrintInfo();
        }

        foreach (var wand in _Inventory.Wands)
        {
            wand.PrintInfo();
        }
        foreach (var item in _Inventory.Pets)
        {
            item.PrintInfo();
        }
    }

    public void LookAtBooks()
    {
        foreach (var book in _Inventory.SpellBooks)
        {
            book.PrintInfo();
        }
    }

    public void LookAtWands()
    {
        Console.WriteLine("List of your wands:");
        foreach (var wand in _Inventory.Wands)
        {
            wand.PrintInfo();
        }
    }

    public void LookAtPets()
    {
        Console.WriteLine("List of your Pets:");
        foreach (var pet in _Inventory.Pets)
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