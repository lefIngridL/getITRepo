namespace Harry_Potter;

public class Spell
{
    public string Incantation { get; set; }
    public string Name { get; set; }
    public SpellType Type { get; set; }
    public string Pronunciation { get; set; }
    public string Description { get; set; }
    public string Etymology { get; set; }

    public Spell(string incantation, string name, SpellType type, string pronunciation, string description, string etymology)
    {
        Incantation = incantation;
        Name = name;
        Type = type;
        Pronunciation = pronunciation;
        Description = description;
        Etymology = etymology;
    }

    public void PrintSpell()
    {
        Console.WriteLine($"Spell: {Incantation}");
    }
}