namespace Harry_Potter;

public class Store
{
    
    public List<Pet> Pets = new List<Pet>
    {
        new Pet(Item_Type.Pet, 15, Coinage.GoldGalleon, null, Pet_List.Cat),
        new Pet(Item_Type.Pet, 12, Coinage.GoldGalleon, null, Pet_List.Owl),
        new Pet(Item_Type.Pet, 5, Coinage.GoldGalleon, null, Pet_List.Rat)
    };
    public List<Wand> Wands = new List<Wand>
    {
        new Wand(Item_Type.Wand, 7,Coinage.GoldGalleon, WandWood.Vine, WandCore.Dragon_heartstring, 10.75, WandFlex.Slightly_yielding),
        new Wand(Item_Type.Wand,7,Coinage.GoldGalleon,WandWood.Ash,WandCore.Dittany_Stalk, 10, WandFlex.Slightly_springy),
    };

    public Store()
    {
        
    }

    public void ShowWares()
    {
        Console.WriteLine($"Take a look at my wares:");
        foreach (var pet in Pets)
        {
            pet.PrintInfo();
        }

        foreach (var wand in Wands)
        {
            wand.PrintInfo();
        }
    }

    public void ShowPets()
    {
        Console.WriteLine("Here are the pets on offer:");
        foreach (var pet in Pets)
        {
            pet.PrintInfo();
        }
    }

    public void ShowWands()
    {
        Console.WriteLine("These are the wands I'm offering:");
        foreach (var wand in Wands)
        {
            wand.PrintInfo();
        }
    }
}