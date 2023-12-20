using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets.Cats.CatFur;

namespace Harry_Potter.Items.Pets.Cats;

public class SiameseCat : Cat
{
    

    public SiameseCat(int? price, Coinage? coinage, string? name, int years, FurColor? furcolor, FurLength? furlength = FurLength.Short, FurPatterns furpattern = FurPatterns.Pointed, FurQuality? furQuality = CatFur.FurQuality.Silky, CatBreed breed = CatBreed.Siamese) : base(price, coinage, name, years, furcolor, furlength, furpattern, furQuality, breed)
    {
        
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\n------\n\n");
    }
}