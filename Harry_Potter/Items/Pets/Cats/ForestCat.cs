using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets.Cats.CatFur;

namespace Harry_Potter.Items.Pets.Cats;

public class ForestCat : Cat
{
    
    


    public ForestCat(int? price, Coinage? coinage, string? name, int years, FurColor? furcolor,  FurPatterns furpattern,FurLength? furlength = CatFur.FurLength.Long, FurQuality? furQuality = CatFur.FurQuality.DoubleCoat, CatBreed breed = CatBreed.ForestCat) : base(price, coinage, name, years, furcolor, furlength, furpattern, furQuality, CatBreed.ForestCat)
    {
      
        
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\n------\n\n");
    }
}