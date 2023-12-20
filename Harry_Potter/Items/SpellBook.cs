using Harry_Potter.Items.Money;
using Harry_Potter.Magic;

namespace Harry_Potter.Items;

public class SpellBook : Item
{
    public string Title { get; set; }
    public readonly Item_Type Type = Item_Type.Book;
    public List<Spell> Spells { get; set; }
    //{
    //    new Spell("Aberto","Opening Charm", SpellType.Charm, "Ah-bare-toh", "A spell used to open doors.", "Portuguese for 'open'. Compare Spanish 'abierto'."),
    //    new Spell("Accio", "Summoning Charm", SpellType.Charm, "AK-ee-oh","Summons an object towards the caster","The Latin word accio means \"I call\" or \"I summon\"."),
    //    new Spell("Arresto Momentum","Slowing Charm",SpellType.Charm,"ah-REST-oh mo-MEN-tum","Decreases the velocity of a moving target"," Likely the combination of the Anglo-French arester, meaning \"to bring to a stop\" and the Latin momentum, meaning \"the force or strength gained whilst moving\"; the literal translation hence is \"Bring the force or strength gained whilst moving to a stop\"."),
    //    new Spell("Ascendio","Ascendio",SpellType.Charm,"ah-SEN-dee-oh","Lifts the caster high into the air. The charm also works underwater, propelling the caster above the surface."," Derived from Latin ascendo, meaning \"to climb\""),
    //    new Spell("Levicorpus","Dangling Jinx",SpellType.Jinx,"leh-vee-COR-pus","Hoists people up into the air by their ankle.","Latin levare, \"raise\" and corpus, \"body\" or \"corpse\"."),
    //    new Spell("Legilimens","Legilimency Spell",SpellType.Charm,"Le-JIL-ih-mens","Allows the caster to delve into the mind of the victim, allowing the caster to see the memories, thoughts, and emotions of the victim.","Latin legere (\"to read\") and mens (\"mind\")."),
    //    new Spell("Bombarda", "Exploding Charm", SpellType.Charm,"bom-BAR-dah", "Provokes a small explosion."," From the word bombard, meaning \"to attack a place or person continually with bombs or other missiles\"."),
    //    new Spell("Reparo","Mending Charm", SpellType.Charm, "reh-PAH-roh", "Seamlessly repairs broken objects.","Latin reparo meaning \"to renew\" or \"repair\""),
    //    new Spell("Alohomora","Unlocking Charm",SpellType.Charm,"ah-LOH-ho-MOR-ah","Unlocks doors and other locked objects.","The incantation is derived from the West African Sidiki dialect used in geomancy; it means \"friendly to thieves\"."),
    //    new Spell("Stupefy","Stunning Spell", SpellType.Charm, "STOO-puh-fye", "Stuns the target, rendering them unconscious.", "English stupefy, which means 'to put into a stupor', a temporary vegetative state."),
    //    new Spell("Expelliarmus", "Disarming Charm",SpellType.Charm, "ex-PELL-ee-ARE-muss","Forces whatever an opponent is holding to fly out of their hand.","Probably a combination of Latin expello, meaning \"expel\", and arma, meaning \"weapon\"." ),
    //    new Spell("Expecto Patronum","Patronus Charm",SpellType.Charm,"ecks-PECK-toh pah-TROH-numb","This charm is a highly powerful and advanced protective spell\n which will conjure a spirit guardian of their positive emotions\n to defend against dark creatures;\n it can also send messages to other witches or wizards.\n The Patronus takes the form of an animal,\n unique to each person who casts it.\n The form of a Patronus can change when one has undergone\n a period of heightened emotion.","Patronus means \"protector\" in Latin; in archaic Latin, it means \"father\"; considering the form Harry's takes, this is interesting. The Latin word expecto means \"I await\""),
    //    new Spell("Wingardium Leviosa","Levitation Charm",SpellType.Charm,"win-GAR-dee-um lev-ee-OH-sa","Makes objects fly, or levitate.","\"Wingardium\" almost certainly contains English wing, meaning \"fly\",\n and Latin arduus, meaning \"high\".\n \"Leviosa\" probably originates from Latin levis, meaning \"light\"."),
    //    new Spell("Petrificus Totalus","Full Body-Bind Curse",SpellType.Curse,"pe-TRI-fi-cus to-TAH-lus","Used to temporarily bind the victim's body\n in a position much like that of a soldier at attention;\n the victim will usually fall to the ground.","Latin petra, meaning \"stone\",\n and fieri (past participle factus), meaning \"to become\";\n totalus comes from Latin \"totus\", meaning \"complete\"."),
    //    new Spell("Riddikulus","Boggart Banishing Spell",SpellType.Charm,"rih-dih-KUL-lus","A spell used when fighting a Boggart,\n \"Riddikulus\" forces the Boggart to take the appearance\n of an object the caster is focusing on.\n Best results can be achieved if the caster is focusing\n on something humorous,\n with the desire that laughter will weaken the Boggart", " Latin word ridiculus, \"laughable\" (but perhaps \"absurd\" or \"silly\" in this context)."),
    //    new Spell("Lumos","Wand-Lighting Charm",SpellType.Charm,"LOO-mos","Illuminates the tip of the caster's wand, allowing the caster to see in the dark.","Latin lumen, \"light\"."),


    //};

    public SpellBook(int? price, Coinage? coinage, string title, List<Spell> spells) : base(price, coinage)
    {
        Title = title;
        Spells = spells;
    }
    public void ReadBook()
    {
        Console.WriteLine(Title);
        int nr = 1;
        foreach (var spell in Spells)
        {
            Console.WriteLine($"----Nr. {nr}----");
            Console.WriteLine(spell.Name);
            nr++;
        }
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"\n--Item type: {Type}--\n\nTittel: {Title}");
        base.PrintInfo();
    }
}