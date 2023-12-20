using Harry_Potter.Items;
using Harry_Potter.Items.Money;

namespace Harry_Potter.Items.Pets;

public class Pet : Item
{

    public string? Name { get; set; }
    public int Years { get; set; }
    
    public readonly Item_Type Type = Item_Type.Pet;

    public Pet(int? price, Coinage? coinage, string? name, int years) : base(price, coinage)
    {
        Name = name;
        Years = years;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Name ??= "Nameless";
        Console.WriteLine($"Item type: {Type}\nName: {Name}\nAge in years: {Years}\n");
    }

}