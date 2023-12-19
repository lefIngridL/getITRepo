using Harry_Potter.Entity;

namespace Harry_Potter.Places;

public static class Hogwarts
{
    public static void AtHogwarts(Store store, Character harry)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(
                "You are at Hogwarts school of Witchcraft and Wizardry. Time to practice some spells!\n'S' - Read a Spell Book\n'W' - Cast a spell\n'I' - Open inventory\n'X' - Travel back to Diagon Alley.");
            var input = Console.ReadLine();

            if (input != null)
            {
                switch (input)
                {
                    case "S":
                        ReadABook(store, harry);

                        break;
                    case "W":
                        Console.WriteLine("Lets have a look at the spells you know!");
                        harry.PrintSpellKnowledge();

                        Console.WriteLine("Indicate by number, wich Spell you want to Cast.\n'X' - EXIT");
                        var SpellStr = Console.ReadLine();

                        if (SpellStr != null)
                        {
                            switch (SpellStr)
                            {
                                case "X":

                                    break;
                                default:
                                    if (int.TryParse(SpellStr, out _))
                                    {
                                        int spellNum = Convert.ToInt32(SpellStr);
                                        if (spellNum <= harry.KnownSpells.Knowledge.Count && spellNum is > 0 and int)
                                        {
                                            harry.KnownSpells.Knowledge[spellNum - 1].CastSpell();
                                            Console.WriteLine("Want to know more about this spell? Read a book!");
                                            Thread.Sleep(6000);
                                        }
                                        else Console.WriteLine("Invalid Input");
                                    }
                                    else Console.WriteLine("Invalid Input");
                                    break;
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                            Thread.Sleep(1000);
                        }
                        break;
                    case "I":
                        harry.Trunk(store, harry);
                        break;

                    case "X":
                        return;
                    default:
                        Console.WriteLine("Invalid command");
                        Thread.Sleep(2000);
                        break;
                }
            }
            else Console.WriteLine("Invalid input");
        }

    }

    public static void LearnNewSpell(int num, int num2, Character harry, Store store)
    {
        Console.WriteLine(
            "Would you like to learn this spell? type 'Y' for 'yes', type 'N' for no.\nType 'X' to exit.");
        var input = Console.ReadLine();

        switch (input)
        {
            case "Y":
                harry.KnownSpells.Knowledge.Add(harry.Inventory.SpellBooks[num - 1].Spells[num2 - 1]);
                Console.WriteLine("You now know the following Spells:");
                harry.KnownSpells.Show();
                Thread.Sleep(6000);
                break;
            case "N":
                ReadABook(store, harry);
                break;
            case "X":
                return;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }




    public static void ReadABook(Store store, Character harry)
    {
        Console.Clear();
        Console.WriteLine("Lets have look at the spell book!");
        harry.LookAtBooks();
        Console.WriteLine("Indicate by number, which book you want to look at.\n'X' - EXIT");
        var numStr = Console.ReadLine();
        switch (numStr)
        {
            case "X":
                AtHogwarts(store, harry);
                break;
            default:
                if (numStr != null)
                {
                    Console.WriteLine($"numStr: {numStr}, harry.Inventory.SpellBooks.Count: {harry.Inventory.SpellBooks.Count}");
                    if (int.TryParse(numStr, out _))
                    {
                        int num = Convert.ToInt32(numStr);
                        if (num <= harry.Inventory.SpellBooks.Count && num is > 0 and int)
                        {
                            harry.Inventory.SpellBooks[num - 1].ReadBook();
                            Console.WriteLine("Indicate by number, what Spell you would like to read about.'X' - EXIT");
                            var numStr2 = Console.ReadLine();
                            switch (numStr2)
                            {
                                case "X":
                                    ReadABook(store, harry);
                                    break;
                                default:
                                    if (numStr2 != null && int.TryParse(numStr2, out _))
                                    {
                                        int num2 = Convert.ToInt32(numStr2);
                                        if (num2 <= harry.Inventory.SpellBooks[num - 1].Spells.Count && num2 is > 0 and int)
                                        {
                                            harry.Inventory.SpellBooks[num - 1].Spells[num2 - 1].PrintSpell();
                                            Console.WriteLine(
                                                "Would you like to learn this spell? type 'Y' for 'yes'.\n'X' - EXIT.");
                                            var ans = Console.ReadLine();
                                            switch (ans)
                                            {
                                                case "X":
                                                    ReadABook(store, harry);
                                                    break;
                                                case "Y":
                                                    LearnNewSpell(num, num2, harry, store);
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("Invalid input");
                                                    Thread.Sleep(1000);
                                                    break;
                                            }

                                        }
                                        else Console.WriteLine("Invalid Input");

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Invalid input");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                            }


                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input, out of range.");
                            Thread.Sleep(1000);
                        }

                    }
                    else Console.WriteLine("Invalid input");
                }
                else Console.WriteLine("Invalid Input");

                break;
        }

    }
}