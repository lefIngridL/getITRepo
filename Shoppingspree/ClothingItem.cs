namespace Shoppingspree;

public class ClothingItem : InventoryItem, ISellable
{
    public string Farge { get; }
    public Size Størrelse { get; }

    public ClothingItem(string navn, int antall, double pris, string farge, Size størrelse) : base(navn, antall, pris)
    {
        Farge = farge;
        Størrelse = størrelse;
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