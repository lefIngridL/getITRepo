namespace Harry_Potter;

public abstract class Item
{
    public Item_Type Type { get; set; }
    public int? Price { get; set; }
    public Coinage? Coinage { get; set; }

    protected Item(Item_Type type, int? price, Coinage? coinage)
    {
        Type = type;
        Price = price;
        Coinage = coinage;
    }

    public void PrintInfo()
    {
        var pris = string.Empty;
        if (Price != null)
        {
            pris = Price.ToString();
            Console.WriteLine($"Type: {Type}\nPrice: {pris} {Coinage}");
        }
        else Console.WriteLine($"Type: {Type}");

    }
}