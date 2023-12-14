namespace Harry_Potter;

public class Wand : Item
{
    public WandWood Wood { get; set; }
    public WandCore Core { get; set; }
    public double Inch { get; set; }
    public WandFlex Flex { get; set; }

    public Wand(Item_Type type, int? price, Coinage? coinage, WandWood wood, WandCore core, double inch, WandFlex flex) : base(type, price, coinage)
    {
        Wood = wood;
        Core = core;
        Inch = inch;
        Flex = flex;
    }

    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"---Wand Properties----\nTreverk: {Wood}\nCore: {Core}\nLength: {Inch}\nFlexibility: {Flex}\n");
    }

}