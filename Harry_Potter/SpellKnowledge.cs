namespace Harry_Potter;

public class SpellKnowledge
{
    public List<Spell> Knowledge { get; set; }

    public SpellKnowledge(List<Spell> knowledge)
    {
        Knowledge = knowledge;
    }
}