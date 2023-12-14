namespace Harry_Potter;

public class Character
{
    public string Name { get; set; }
    public House House { get; set; }
    public List<Item> Inventory { get; set; }

    public Purse _Purse { get; set; }
    public SpellKnowledge KnownSpells { get; set; }

    public Character(string name, House house, List<Item> inventory, Purse purse, SpellKnowledge knownSpells)
    {
        Name = name;
        House = house;
        Inventory = inventory;
        _Purse = purse;
        KnownSpells = knownSpells;
    }

    public void PrintChar()
    {
        Console.WriteLine($"Navn: {Name}\nHus: {House}\nInnhold i koffert:");
        foreach (var item in Inventory)
        {
            item.PrintInfo();
        }
    }
}