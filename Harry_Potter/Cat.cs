namespace Harry_Potter;

public class Cat : Pet
{
    public CatBreed? Breed { get; set; }
    public FurColor? FurColor { get; set; }
    public FurLength? FurLength { get; set; }
    public FurPattern? FurPattern { get; set; }
    public FurQuality? FurQuality { get; set; }

    public Cat(Item_Type type, int? price, Coinage? coinage, string? name, int years, Pet_List petType, CatBreed? breed, FurColor? furColor, FurLength? furLength, FurPattern? furPattern, FurQuality? furQuality) : base(type, price, coinage, name, years, petType)
    {
        Breed = breed;
        FurColor = furColor;
        FurLength = furLength;
        FurPattern = furPattern;
        FurQuality = furQuality;
    }

    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Details about cat:\nBreed: {Breed}\nFur color: {FurColor}\nFur length: {FurLength}\nFur pattern: {FurPattern}\nFur quality: {FurQuality}");
    }
}