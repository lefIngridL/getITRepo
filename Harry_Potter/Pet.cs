namespace Harry_Potter;

public class Pet : Item
{
    
    public string? Name { get; set; }
    public Pet_List PetType { get; set; }

    public Pet(Item_Type type, int? price, Coinage? coinage, string? name, Pet_List petType) : base(type, price, coinage)
    {
        Name = name;
        PetType = petType;
    }

    public void PrintInfo()
    {
        base.PrintInfo();
        string Navn = string.Empty;
        if (Name == null)
        {
            Navn = "Nameless";
        }else Navn = Name;
        Console.WriteLine($"Name: {Navn}\nType of pet: {PetType}\n");
    }
    
}