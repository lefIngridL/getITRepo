using Harry_Potter.Items.Money;

namespace Harry_Potter.Items;

public abstract class Item
{
    public Item_Type Type { get; }
    public int? Price { get; set; }
    public Coinage? Coinage { get; set; }

    protected Item(Item_Type type, int? price, Coinage? coinage)
    {
        Type = type;
        Price = price;
        Coinage = coinage;
    }

    public virtual void PrintInfo()
    {
        if (Price != null)
        {
            var pris = Price.ToString();
            Console.WriteLine($"Type: {Type}\nPrice: {pris} {Coinage}");
        }
        else Console.WriteLine($"Type: {Type}");

    }
}