namespace Harry_Potter.Magic;

public class SpellKnowledge
{
    public List<Spell> Knowledge { get; set; }

    public SpellKnowledge(List<Spell> knowledge)
    {
        Knowledge = knowledge;
    }

    public void Show()
    {
        int nr = 1;
        foreach (var spell in Knowledge)
        {
            Console.WriteLine($"----Nr. {nr}----");
            spell.PrintSpell();
            nr++;
        }
    }

    public void ShowShort()
    {
        int nr = 1;
        foreach (var spell in Knowledge)
        {
            Console.WriteLine($"----Nr. {nr}----");
            spell.PrintShortSpell();
            nr++;
        }
    }
}