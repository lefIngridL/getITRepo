using Harry_Potter.Entity;
using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets;
using Harry_Potter.Items.Wands;
using Harry_Potter.Items;
using Harry_Potter.Magic;
using Harry_Potter.Places;
using static System.Net.Mime.MediaTypeNames;

namespace Harry_Potter;

public static class Game
{
    public static void Start()
    {
        var newPerson = CreateChar();
        var Harry = new Character("Harry Potter", "male", House.Griffindor, new Inventory(new List<Pet>(), new List<Wand>(), new List<SpellBook>()), new Purse(100, 50, 25), new SpellKnowledge(new List<Spell>()));
        var standardBookOfSpellsGrade1 = new SpellBook(10, Coinage.GoldGalleon, "Standard Book Of Spells Grade 1", new List<Spell>
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

        var standardBookOfSpellsGrade2 = new SpellBook(10, Coinage.GoldGalleon, "Standard Book Of Spells Grade 2", new List<Spell>
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

        Harry.Inventory.Pets.Add(new Owl(null, null, "Hedwig", 1, OwlSpecies.Barn_owl));
        Harry.Inventory.Wands.Add(new Wand(null, null, WandWood.Holly, WandCore.Phoenix_feather, 11.5, WandFlex.Supple));
        Harry.KnownSpells.Knowledge.Add(standardBookOfSpellsGrade1.Spells[0]);
        string WelcomeMsg = "Welcome to my humble Harry Potter simulator!";
        //Welcome(WelcomeMsg, Harry);
        Welcome(WelcomeMsg, newPerson);

        //Console.WriteLine("Here is info in Harry Potter:");
        //Harry.PrintChar();
        //foreach (var spell in Harry.KnownSpells.Knowledge)
        //{
        //    spell.PrintSpell();
        //}


        var Butikk = new Store();
        Butikk.Books.Add(standardBookOfSpellsGrade1);
        Butikk.Books.Add(standardBookOfSpellsGrade2);
        
        //Enter(Butikk, Harry);
        Enter(Butikk, newPerson);
    }

    public static Character CreateChar()
    {
        Console.WriteLine("Write name of new player: ");
        string name = Console.ReadLine();
        Console.WriteLine("What is the gender of the new player?");
        string gender = Console.ReadLine();
        Harry_Potter.Entity.House house = House.UnSorted;
        List<Pet> pets = new List<Pet>();
        List<Wand> wands = new List<Wand>();
        List<SpellBook> spellBooks = new List<SpellBook>();
        Harry_Potter.Entity.Inventory inventory = new Inventory(pets, wands, spellBooks);
        Harry_Potter.Items.Money.Purse purse = new Purse(100, 50, 70);
        List<Spell> spellsList = new List<Spell>();
        Harry_Potter.Magic.SpellKnowledge spells = new SpellKnowledge(spellsList);
        var Person = new Character(name, gender, house, inventory, purse, spells);
        return Person;
    }

    public static void Welcome(string text, Character Harry)
    {
        
        string text2 = "----tap a key to continue----";
        int width = Console.WindowWidth;
        int leftMargin = (width - text.Length) / 2;
        int leftMargin2 = (width - text2.Length) / 2;

        Console.WriteLine("\n\n" + new string(' ', leftMargin) + text);

        DisplayLargeText();
        Console.WriteLine("\n\n" + new string(' ', leftMargin) + text2);
        Console.ReadKey();
        Console.Clear();
        
        string text3 = $"Here is info on the new player:";
        int leftMargin3 = (width - text3.Length) / 2;
        Console.WriteLine("\n\n" + new string(' ', leftMargin) + text3);
        Thread.Sleep(1500);
        Harry.PrintChar();

        foreach (var spell in Harry.KnownSpells.Knowledge)
        {
            spell.PrintSpell();
        }
        Console.WriteLine("\n\n" + new string(' ', leftMargin) + text2);
        Console.ReadKey();

    }

    static void DisplayLargeText()
    {
        // ASCII art for larger text
        string[] largeText = {

            "                           ______    ______                   ",
            " ||    ||      //\\\\     ||    \\\\  ||    \\  \\\\    //    ",
            "  ||    ||     //  \\\\    ||    ||  ||    ||  \\\\  //       ",
            "  ||====||    //====\\\\   ||___//   ||___//    \\\\//        ",
            " ||    ||   //      \\\\  ||  \\\\    ||  \\\\      //        ",
            " ||    ||  //        \\\\ ||   \\\\   ||   \\\\    //         ",
            "",
            "    ______             __________  __________   __________     ______    ",
            "  ||    \\\\    ____       ||          ||      ||_________|    ||    \\  ",
            "   ||    ||  //    \\\\     ||          ||      ||_______       ||    || ",
            "    ||___//  ||      ||    ||          ||      ||_______|      ||___//   ",
            "  ||        \\\\    //     ||          ||      ||_________     || \\\\   ",
            "   ||          ----       ||          ||      ||_________|    ||  \\\\   ",

        };


        //Console.WriteLine("\n\n" + new string(' ', leftMargin) + text);

        foreach (string line in largeText)
        {
            int width = Console.WindowWidth;
            int leftMargin = (width - line.Length) / 2;
            //Console.WriteLine(line);
            Console.WriteLine(new string(' ', leftMargin) + line);
        }

    }
    public static void Enter(Store store, Character harry)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\nYou are standing in front the entrance to Diagon Alley.\n" +
                              $"Command List:\n-A - Enter Diagon Alley\n-X - Stay in the Leaky Cauldron.\n-H - Travel to Hogwarts\n-I - Open inventory\n-Q - Profile\n-EXIT - exit the game.");
            var input = Console.ReadLine();

            switch (input)
            {
                case "A":
                    store.Shop(store, harry);
                    break;

                case "X":
                    
                    LeakyCauldron.TomsBar(store, harry);
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
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    Thread.Sleep(2000);
                    break;

            }
        }
    }


}