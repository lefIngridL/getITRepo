namespace Abax;

class Boat : Vehicle
{
    private Vehicle _vehicleImplementation;

    public double gross_tonnage { get; set; }


    public Boat(decimal? maxSpeed, string regNo, decimal effect, Vehicle_Type? type, double grossTonnage) : base(maxSpeed, regNo, effect, type)
    {
        gross_tonnage = grossTonnage;
    }

    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Bruttotonnasje: {gross_tonnage}tonn");
    }

    public override void Run(Vehicle vehicle)
    {
        _vehicleImplementation.Run(vehicle);
    }

    public void Run(Boat boat)
    {
        base.PrintInfo();
        Console.WriteLine(gross_tonnage);
    }


   
    
}
//båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.