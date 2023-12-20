using Harry_Potter.Items.Money;

namespace Harry_Potter.Items;

public abstract class Item
{
    public int? Price { get; set; }
    public Coinage? Coinage { get; set; }

    protected Item(int? price, Coinage? coinage)
    {
        Price = price;
        Coinage = coinage;
    }

    public virtual void PrintInfo()
    {
        if (Price != null)
        {
            var pris = Price.ToString();
            Console.WriteLine($"Price: {pris} {Coinage}");
        }
        else Console.WriteLine($"");

    }
}