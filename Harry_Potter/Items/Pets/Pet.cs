using Harry_Potter.Items;
using Harry_Potter.Items.Money;

namespace Harry_Potter.Items.Pets;

public class Pet : Item
{

    public string? Name { get; set; }
    public int Years { get; set; }
    private Pet_List PetType { get;}

    public Pet(Item_Type type, int? price, Coinage? coinage, string? name, int years, Pet_List petType) : base(type, price, coinage)
    {
        Name = name;
        Years = years;
        PetType = petType;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        if (Name == null)
        {
            Name = "Nameless";
        }
        else
        Console.WriteLine($"Name: {Name}\nType of pet: {PetType}\nAge in years: {Years}\n");
    }

}