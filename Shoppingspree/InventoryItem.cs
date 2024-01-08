namespace Shoppingspree;

public abstract class InventoryItem
{
    public string Navn { get; }
    public int Antall { get; }
    public double Pris { get; }

    protected InventoryItem(string navn, int antall, double pris)
    {
        Navn = navn;
        Antall = antall;
        Pris = pris;
    }

   
}