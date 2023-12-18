namespace Harry_Potter;

public class Rat : Pet
{
    public FurColor FurColor { get; set; }

    public Rat(Item_Type type, int? price, Coinage? coinage, string? name, int years, Pet_List petType, FurColor furColor) : base(type, price, coinage, name, years, petType)
    {
        FurColor = furColor;
    }
}