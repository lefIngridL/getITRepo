using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets.Cats.CatFur;

namespace Harry_Potter.Items.Pets.Cats;

public class KneazleCat : Cat
{
    

    public KneazleCat(int? price, Coinage? coinage, string? name, int years, FurColor? furcolor, FurLength? furlength = FurLength.Long, FurPatterns furpattern = FurPatterns.Tabby, FurQuality? furQuality = CatFur.FurQuality.DoubleCoat, CatBreed breed = CatBreed.Kneazle) : base(price, coinage, name, years, furcolor, furlength, furpattern, furQuality, breed)
    {
        
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\n------\n\n");
    }
}