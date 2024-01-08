namespace Shoppingspree;

public class ElectronicItem : InventoryItem, ISellable
{
    public double voltage { get; }
    public int warranty { get; }

    public ElectronicItem(string navn, int antall, double pris, double voltage, int warranty) : base(navn, antall, pris)
    {
        this.voltage = voltage;
        this.warranty = warranty;
    }
    public void Calculate()
    {
        double Total = Antall * Pris;
        Console.WriteLine($"Prisen for {Antall}stk {Navn} er {Total}kr ");
    }

    public double SinglePrice()
    {
        return this.Pris;
    }
}