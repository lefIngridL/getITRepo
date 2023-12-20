using Harry_Potter.Items;
using Harry_Potter.Items.Money;

namespace Harry_Potter.Items.Pets;

public class Owl : Pet
{
    public OwlSpecies? Species { get; set; }
    public readonly Pet_List _petType = Pet_List.Owl;
    public Owl(int? price, Coinage? coinage, string? name, int years, OwlSpecies? species) : base(price, coinage, name, years)
    {
        Species = species;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Pet type: {_petType}\nOwl species: {Species}\n------\n");
    }
}