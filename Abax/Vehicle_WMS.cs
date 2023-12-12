namespace Abax;

abstract class Vehicle_WMS 
{
    public int Max_Speed { get; set; }
    public string Max_Speed_unit { get; set; }

    protected Vehicle_WMS(int maxSpeed, string maxSpeedUnit)
    {
        Max_Speed = maxSpeed;
        Max_Speed_unit = maxSpeedUnit;
    }

    public virtual void PrintInfo()
    {
        
        Console.WriteLine($"Maksfart: {Max_Speed}{Max_Speed_unit}");
    }
}