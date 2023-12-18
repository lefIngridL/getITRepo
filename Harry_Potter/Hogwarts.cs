namespace Harry_Potter;

public static class Hogwarts
{
    public static void AtHogwarts(Store Butikk, Character Harry)
    {
        while (true)
        {
            //Console.Clear();
            Console.WriteLine(
                "You are at Hogwarts school of Witchcraft and Wizardry. Time to practice some spells!\n press 'S' to read a Spell Book, 'W' to cast a spell, or 'X' to travel back to Diagon Alley.");
            var input = Console.ReadLine();

            if (input != null)
            {
                switch (input)
                {
                    case "S":
                        ReadABook(Butikk, Harry);
                   
                        break;
                    case "W":
                        Console.WriteLine("Lets have a look at the spells you know!");
                        Harry.PrintSpellKnowledge();

                        Console.WriteLine("Indicate by number, wich Spell you want to Cast.\n'X' - EXIT");
                        var SpellStr = Console.ReadLine();
                        if (SpellStr != null && SpellStr != "X")
                        {
                            int Spellnum;
                            if (int.TryParse(SpellStr, out Spellnum))
                            {
                                Spellnum = Convert.ToInt32(SpellStr);
                                if (Spellnum <= Harry.KnownSpells.Knowledge.Count && Spellnum > 0 &&
                                                           Spellnum.GetType() == (typeof(Int32)))
                                {
                                    Harry.KnownSpells.Knowledge[Spellnum - 1].CastSpell();
                                    Console.WriteLine("Want to know more about this spell? Read a book!");
                                }
                            }
                        }
                        else if (SpellStr == "X") return;


                        break;
                    case "X":
                        return;
                        break;
                }
            }
        }

    }

    public static void LearnNewSpell(int num, int num2, Character Harry, Store Butikk)
    {
        Console.WriteLine(
            "Would you like to learn this spell? type 'Y' for 'yes', type 'N' for no.\nType 'X' to exit.");
        var input = Console.ReadLine();
        if (input == "Y" || input == "N")
        {
            switch (input)
            {
                case "Y":
                    Harry.KnownSpells.Knowledge.Add(Harry._Inventory.SpellBooks[num - 1].Spells[num2 - 1]);
                    Console.WriteLine("You now know the following Spells:");
                    Harry.KnownSpells.Show();
                    break;
                case "N":
                    AtHogwarts(Butikk, Harry);
                    break;
            }
        }
        else if (input == "X")
        {
            return;
        }

    }

    internal static void ReadABook(Store Butikk, Character Harry)
    {
        Console.WriteLine("Lets have look at the spellbook!");
        Harry.LookAtBooks();
        Console.WriteLine("Indicate by number, wich book you want to look at.\n'X' - EXIT");
        var numStr = Console.ReadLine();
        if (numStr != null && numStr != "X")
        {
            int num;
            if (int.TryParse(numStr, out num))
            {
                num = Convert.ToInt32(numStr);
                if (num <= Harry._Inventory.SpellBooks.Count && num > 0 && num.GetType() == (typeof(Int32)))
                {
                    Harry._Inventory.SpellBooks[num - 1].ReadBook();
                    Console.WriteLine("Indicate by number, what Spell you would like to read about.'X' - EXIT");
                    var numStr2 = Console.ReadLine();
                    int num2 = Convert.ToInt32(numStr2);
                    if (num2 <= Harry._Inventory.SpellBooks[num - 1].Spells.Count && num2 > 0 &&
                        num2.GetType() == (typeof(Int32)))
                    {
                        Harry._Inventory.SpellBooks[num - 1].Spells[num2 - 1].PrintSpell();

                        LearnNewSpell(num, num2, Harry, Butikk);
                    }
                    else Console.WriteLine("Invalid Input");

                }

            }
            else Console.WriteLine("Invalid input");
        }
        else if (numStr == "X") return;
    }
}