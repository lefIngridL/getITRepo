using System.Diagnostics;
using System.Xml.Linq;
using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets.Cats.CatFur;

namespace Harry_Potter.Items.Pets.Cats;

public class Cat : Pet
{

    public FurColor? Furcolor { get; }
    public FurLength? Furlength { get; }
    public FurPatterns Furpattern { get; }
    public FurQuality? FurQuality { get; }
    private readonly Pet_List _petType = Pet_List.Cat;
    public CatBreed Breed { get; }

    public Cat(int? price, Coinage? coinage, string? name, int years, FurColor? furcolor, FurLength? furlength, FurPatterns furpattern, FurQuality? furQuality, CatBreed breed = CatBreed.mix) : base(price, coinage, name, years)
    {
        Furcolor = furcolor;
        Furlength = furlength;
        Furpattern = furpattern;
        FurQuality = furQuality;
        Breed = breed;
    }


    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Pet type: {_petType}\nCat Breed: {Breed}\n\nDetails about cat:\nFur color: {Furcolor}\nFur length: {Furlength}\nFur pattern: {Furpattern}\nFur quality: {FurQuality}\n");
    }
}