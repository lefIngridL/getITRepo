namespace LagerStyringSys;

public class Klær : IProduct
{
    public string Size { get; set; }

    public string Navn { get; set; }
    public double Pris { get; set; }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"varenavn: {Navn}\nStørrelse: {Size}\nPris: {Pris}Kr,-\n");
    }

    public Klær(string size, string navn, double pris)
    {
        Size = size;
        Navn = navn;
        Pris = pris;
    }

    
}