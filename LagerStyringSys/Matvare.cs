namespace LagerStyringSys;

public class Matvare : IProduct
{
    public string ExpireDate { get; set; }

    public string Navn { get; set; }
    public double Pris { get; set; }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"varetype: {Navn}\nPris: {Pris}Kr,-\nBest Før: {ExpireDate}\n");
    }

    public Matvare(string expireDate, string navn, double pris)
    {
        ExpireDate = expireDate;
        Navn = navn;
        Pris = pris;
    }
}