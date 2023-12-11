namespace Abax;

abstract class Vehicle_WMS : Vehicle
{
    public int Max_Speed { get; set; }
    public string Max_Speed_unit { get; set; }

    protected Vehicle_WMS(string regNo, double effect, int maxSpeed, string maxSpeedUnit) : base(regNo, effect)
    {
        Max_Speed = maxSpeed;
        Max_Speed_unit = maxSpeedUnit;
    }

    public virtual void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Maksfart: {Max_Speed}{Max_Speed_unit}");
    }
}