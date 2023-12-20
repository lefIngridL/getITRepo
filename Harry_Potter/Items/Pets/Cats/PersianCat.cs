using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets.Cats.CatFur;

namespace Harry_Potter.Items.Pets.Cats;

public class PersianCat : Cat
{
    

    public PersianCat(int? price, Coinage? coinage, string? name, int years, FurColor? furcolor, FurLength? furlength = FurLength.Long, FurPatterns furpattern = FurPatterns.Pointed, FurQuality? furQuality = CatFur.FurQuality.Fluffy, CatBreed breed = CatBreed.Persian) : base(price, coinage, name, years, furcolor, furlength, furpattern, furQuality, breed)
    {
        
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\n------\n\n");
    }
}