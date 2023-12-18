namespace Harry_Potter;

public class Spell
{
    public string Incantation { get; set; }
    public string Name { get; set; }
    public SpellType Type { get; set; }
    public string Pronunciation { get; set; }
    public string Description { get; set; }
    public string Etymology { get; set; }
    public string? Effect { get; set; }

    public Spell(string incantation, string name, SpellType type, string pronunciation, string description, string etymology, string? effect)
    {
        Incantation = incantation;
        Name = name;
        Type = type;
        Pronunciation = pronunciation;
        Description = description;
        Etymology = etymology;
        Effect = effect;
    }

    public void PrintSpell()
    {
        Console.WriteLine($"------\nIncantation: {Incantation}\nCommon name: {Name}\nPronunciation: {Pronunciation}\nType: {Type}\nDecsription: {Description}\nEtymology: {Etymology}\n------");
    }

    public void PrintShortSpell()
    {
        Console.WriteLine(Incantation);
    }

    public void CastSpell()
    {
        Console.WriteLine($"You Cast the {Type} {Incantation}! {Effect}\n");
    }
}