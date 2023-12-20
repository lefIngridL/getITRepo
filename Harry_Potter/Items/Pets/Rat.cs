using Harry_Potter.Items;
using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets.Cats.CatFur;

namespace Harry_Potter.Items.Pets;

public class Rat : Pet
{
    public FurColor FurColor { get; set; }
    public readonly Pet_List _petType = Pet_List.Rat;

    public Rat(int? price, Coinage? coinage, string? name, int years, FurColor furColor) : base(price, coinage, name, years)
    {
        FurColor = furColor;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Pet type: {_petType}\nFur color: {FurColor}\n------\n");
    }
}