namespace Abax;

class Plane : Vehicle
{
    private Vehicle _vehicleImplementation;

    public int Wingspan { get;}
    public int Weigth_Capacity { get;}
    public int Weigth_Self { get;}
    public string Plane_Class { get; }

    public Plane(decimal? maxSpeed, string regNo, decimal effect, Vehicle_Type? type, int wingspan, int weigthCapacity, int weigthSelf, string planeClass) : base(maxSpeed, regNo, effect, type)
    {
        Wingspan = wingspan;
        Weigth_Capacity = weigthCapacity;
        Weigth_Self = weigthSelf;
        Plane_Class = planeClass;
    }

    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Vingespenn: {Wingspan}m\nLasteevne: {Weigth_Capacity}tonn\nEgenvekt: {Weigth_Self}tonn\nFlyklasse: {Plane_Class}\n--------\n");
    }

    public override void Run(Vehicle vehicle)
    {
        _vehicleImplementation.Run(vehicle);
    }

    public void Run(Plane plane)
    {
        Console.WriteLine($"Fly med spesifikasjoner:");
        PrintInfo();
        Console.WriteLine("Bees om å ta av fra rullebanen.");
        Console.WriteLine("Trykk 'A' for å tillate at flyet letter. Trykk 'X' for å avbryte");
        var input = Console.ReadLine();
        if (input != null)
        {
            if (input == "A")
            {
                Console.WriteLine("Flyet tok av og er nå i lufta\n------");
            }

            if (input == "X")
            {
                Console.WriteLine("Oppstart avbrutt\n-------");
            }
            else if (input != "A" && input != "X") Console.WriteLine("Invalid input");

            return;
        }
    }
}
//fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly