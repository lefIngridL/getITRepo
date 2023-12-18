namespace Harry_Potter;

public class Owl : Pet
{
    public OwlSpecies? Species { get; set; }

    public Owl(Item_Type type, int? price, Coinage? coinage, string? name, int years, Pet_List petType, OwlSpecies? species) : base(type, price, coinage, name, years, petType)
    {
        Species = species;
    }

    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Owl species: {Species}\n");
    }
}