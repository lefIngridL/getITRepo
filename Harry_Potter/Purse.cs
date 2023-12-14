namespace Harry_Potter;

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
}