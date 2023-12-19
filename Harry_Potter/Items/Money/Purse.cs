namespace Harry_Potter.Items.Money;

public class Purse
{
    public int Gold { get; set; }
    public int Silver { get; set; }
    public int Bronze { get; set; }

    public Purse(int gold, int silver, int bronze)
    {
        Gold = gold;
        Silver = silver;
        Bronze = bronze;
    }

    public void Balance()
    {
        Console.WriteLine($"You look in your purse and find: \n{Gold} {Coinage.GoldGalleon}s\n{Silver}{Coinage.SilverSickle}s and\n{Bronze} {Coinage.BronzeKnut}s\n");
    }
}