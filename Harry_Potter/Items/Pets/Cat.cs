using Harry_Potter.Items;
using Harry_Potter.Items.Money;

namespace Harry_Potter.Items.Pets;

public class Cat : Pet 
{
    public CatBreed? Breed { get; }
    private FurColor? Furcolor { get; }
    private FurLength? Furlength { get; }
    private FurPatterns Furpattern { get; }
    private FurQuality? FurQuality { get; }

    public Cat(Item_Type type, int? price, Coinage? coinage, string? name, int years, Pet_List petType, CatBreed? breed, FurColor? furcolor, FurLength? furlength, FurPatterns furpattern, FurQuality? furQuality) : base(type, price, coinage, name, years, petType)
    {
        Breed = breed;
        Furcolor = furcolor;
        Furlength = furlength;
        Furpattern = furpattern;
        FurQuality = furQuality;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Details about cat:\nBreed: {Breed}\nFur color: {Furcolor}\nFur length: {Furlength}\nFur pattern: {Furpattern}\nFur quality: {FurQuality}");
    }
}