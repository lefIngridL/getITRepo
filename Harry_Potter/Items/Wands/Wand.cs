using Harry_Potter.Items;
using Harry_Potter.Items.Money;

namespace Harry_Potter.Items.Wands;

public class Wand : Item, IPrintInfo
{
    public WandWood Wood { get; set; }
    public WandCore Core { get; set; }
    public double Inch { get; set; }
    public WandFlex Flex { get; set; }
    public readonly Item_Type _type = Item_Type.Wand;

    public Wand(int? price, Coinage? coinage, WandWood wood, WandCore core, double inch, WandFlex flex) : base(price, coinage)
    {
        Wood = wood;
        Core = core;
        Inch = inch;
        Flex = flex;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Item type: {_type}\n\n---Wand Properties----\nWood: {Wood}\nCore: {Core}\nLength: {Inch} Inches\nFlexibility: {Flex}\n");
    }

}