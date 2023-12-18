namespace Harry_Potter;

public class Inventory
{
    public List<Pet> Pets {get; set; }
    public List<Wand> Wands { get; set; }
    public List<SpellBook> SpellBooks { get; set; }

    public Inventory(List<Pet> pets, List<Wand> wands, List<SpellBook> spellBooks)
    {
        Pets = pets;
        Wands = wands;
        SpellBooks = spellBooks;
    }

    public void ListPets()
    {
        Console.WriteLine("List of your Pets:");
        foreach (var pet in Pets)
        {
            pet.PrintInfo();
        }
    }

    public void ListWands()
    {
        Console.WriteLine("List of your wands:");
        foreach (var wand in Wands)
        {
            wand.PrintInfo();
        }
    }

    public void ListSpellBooks()
    {
        Console.WriteLine("List of your Spell Books:");
        foreach (var book in SpellBooks)
        {
            book.PrintInfo();
        }
    }
}