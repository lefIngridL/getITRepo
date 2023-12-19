using Harry_Potter.Entity;
using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets;
using Harry_Potter.Items.Wands;
using Harry_Potter.Items;
using Harry_Potter.Magic;
using Harry_Potter.Places;

namespace Harry_Potter;

public static class Game
{
    public static void Start()
    {
        var Harry = new Character("Harry Potter","male", House.Griffindor, new Inventory(new List<Pet>(), new List<Wand>(), new List<SpellBook>()), new Purse(100, 50, 25), new SpellKnowledge(new List<Spell>()));
        var standardBookOfSpellsGrade1 = new SpellBook(Item_Type.Book, 10, Coinage.GoldGalleon, "Standard Book Of Spells Grade 1", new List<Spell>
            {
                new ("Lumos", "Wand-Lighting Charm", SpellType.Charm, "LOO-mos",
                    "Illuminates the tip of the caster's wand, allowing the caster to see in the dark.",
                    "Latin lumen, \"light\".", "your wand tip lit up with a bright white light!"),
                new ("Spongify", "Softening Charm", SpellType.Charm, "SPUN-ji-fye",
                    "Softens objects, making them rubbery and bouncy.",
                    "from sponge + ify; to make like a sponge (to make soft)", "The target became soft like a sponge!"),
                new ("Diffindo", "Severing Charm", SpellType.Charm, "dih-FIN-doh",
                    "Used to precisely cut or tear objects.",
                    "Latin diffindere, meaning \"to divide\" or \"to split\".", "A neat and precise cut was made in the target!"),
                new ("Incendio", "Fire-Making Spell", SpellType.Charm, "in-SEN-dee-oh", "Produces fire.",
                    "Latin incendere, \"to set fire (to)\".", "The target lit on fire!"),
                new ("Alohomora", "Unlocking Charm", SpellType.Charm, "ah-LOH-ho-MOR-ah",
                    "Unlocks doors and other locked objects.",
                    "The incantation is derived from the West African Sidiki dialect used in geomancy;\n it means \"friendly to thieves\".", "The lock opened!"),
                new ("Wingardium Leviosa", "Levitation Charm", SpellType.Charm, "win-GAR-dee-um lev-ee-OH-sa",
                    "Makes objects fly, or levitate.",
                    "\"Wingardium\" almost certainly contains English wing, meaning \"fly\",\n and Latin arduus, meaning \"high\".\n \"Leviosa\" probably originates from Latin levis, meaning \"light\".", "The target began to levitate!"),
                new ("Colloportus", "Locking Spell", SpellType.Charm, "cul-loh-POR-tus",
                    "Locks doors and all things that can be locked. It is the counter-charm to the Unlocking Spell.",
                    "Perhaps a portmanteau of the Latin words colligare, which means \"restrain\" and porta, which means \"gate\".", "The lock closed up!"),
                new ("Reparo", "Mending Charm", SpellType.Charm, "reh-PAH-roh",
                    "Seamlessly repairs broken objects.", "Latin reparo meaning \"to renew\" or \"repair\"", "The spell repaired the target!"),

            });

        var standardBookOfSpellsGrade2 = new SpellBook(Item_Type.Book, 10, Coinage.GoldGalleon, "Standard Book Of Spells Grade 2", new List<Spell>
            {
                new ("Tarantallegra","Dancing Feet Spell",SpellType.Charm,"ta-RON-ta-LEG-gra","Makes a target's legs spasm wildly out of control, making it appear as though they are dancing.","Italian tarantella, a kind of fast country dance once popular in parts of Italy,\n supposedly from the frantic motion caused by the bite of a tarantula;\n and allegro, a musical term meaning \"quick\".", "The target began flailing and dancing as if posessed!"),
                new ("Expelliarmus", "Disarming Charm",SpellType.Charm, "ex-PELL-ee-ARE-muss","Forces whatever an opponent is holding to fly out of their hand.","Probably a combination of Latin expello, meaning \"expel\", and arma, meaning \"weapon\".", "The tagets weapon flew from their hand!" ),
                new ("Engorgio","Engorgement Charm",SpellType.Charm,"en-GOR-jee-oh","Causes the target to swell in physical size. Its counter-charm is the Shrinking Charm.","The English word engorge means \"swell\".", "The target began swelling up to a large size!"),
                new ("Immobulus","reezing Charm",SpellType.Charm," ih-MOH-byoo-luhs","Immobilises and stops the actions of the target. It works both on living and inanimate things.","From the Latin “immobilis”, meaning immovable.","The target is perfectly still. It is unable to move."),
                new ("Finite Incantatem","General Counter-Spell",SpellType.Counter_spell,"fi-NEE-tay in-can-TAH-tem","Terminates all spell effects in the vicinity of the caster.","Latin finire, meaning \"to finish\", and incantatem.", "The effect of previous spells was canceled"),
                new ("Obliviate","Memory Charm",SpellType.Charm,"h-BLI-vee-ate","Erases specific memories.","Latin oblivisci, \"forget\".", "Something was forgotten..."),
                new ("Skurge","Skurge Charm",SpellType.Charm,"SKURJ","Cleans up ectoplasm and frightens ghosts and other spirits.","unknown","If any ectoplasm or ghosts were presents, it's gone now..."),
                new ("Rictusempra","Tickling Charm",SpellType.Charm,"ric-tuhs-SEM-pra","Tickles the target until they become weak with laughter.","Possibly the sum of two words; The Latin rictus, meaning \"The expanse of an open mouth\", and semper, meaning \"Always\". Rictus is generally used as an expression of terror, however, \"always an open mouth\" would, in most cases, correspond to the act of laughing uncontrollably.", "The target felt tickling and began laughing uncontrollably!"),

            });

        Harry.Inventory.Pets.Add(new Owl(Item_Type.Pet, null, null, "Hedwig", 1, Pet_List.Owl, OwlSpecies.Barn_owl));
        Harry.Inventory.Wands.Add(new Wand(Item_Type.Wand, null, null, WandWood.Holly, WandCore.Phoenix_feather, 11.5, WandFlex.Supple));
        Harry.KnownSpells.Knowledge.Add(standardBookOfSpellsGrade1.Spells[0]);

        Harry.PrintChar();
        foreach (var spell in Harry.KnownSpells.Knowledge)
        {
            spell.PrintSpell();
        }


        var Butikk = new Store();
        Butikk.Books.Add(standardBookOfSpellsGrade1);
        Butikk.Books.Add(standardBookOfSpellsGrade2);
        Thread.Sleep(2000);
        Enter(Butikk, Harry);
    }

    public static void Enter(Store store, Character harry)
    {
        bool game = true;
        while (game)
        {
            Console.Clear();
            Console.WriteLine($"\nYou are standing in front of a store in Diagon Alley.\n" +
                              $"Command List:\n'A' - Enter the store\n'X' - Stay on the street.\n'H' - Travel to Hogwarts\n'I' - Open inventory\n'Q' - Profile\n'EXIT' - exit the game.");
            var input = Console.ReadLine();

            switch (input)
            {
                case "A":
                    store.Shop(store, harry);
                    break;

                case "X":
                    Console.WriteLine("You are standing in Diagon Alley");
                    break;
                case "H":
                    Hogwarts.AtHogwarts(store, harry);
                    break;
                case "I":
                    harry.Trunk(store, harry);
                    break;
                case "Q":
                    harry.ProfilePage();
                    break;
                case "EXIT":
                    game = false;
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    Thread.Sleep(2000);
                    break;

            }
        }return;
    }


}