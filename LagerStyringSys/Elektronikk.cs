namespace LagerStyringSys;

public class Elektronikk : IProduct
{
    public int Garantitid { get; set; }

    public string Navn { get; set; }
    public double Pris { get; set; }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Varetype: {Navn}\nPris: {Pris}Kr,-\nGarantitid: {Garantitid}mndr\n");
    }

    public Elektronikk(int garantitid, string navn, double pris)
    {
        Garantitid = garantitid;
        Navn = navn;
        Pris = pris;
    }
}