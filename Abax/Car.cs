namespace Abax;

class Car : Vehicle
{
   
   
    public string color { get; set; }


    public Car(decimal? maxSpeed, string regNo, decimal effect, Vehicle_Type? type, string color) : base(maxSpeed, regNo, effect, type)
    {
        this.color = color;
    }

    public void PrintInfo(string name)
    {
        base.PrintInfo();
        Console.WriteLine($"Bil: {name}\nFarge: {color}\nVektklasse:\n-----");
    }

    public void Run(Car car)
    {
        Console.WriteLine($"Bil med følgende egenskaper bees om å kjøre:");
        car.PrintInfo("car");
        Console.WriteLine("For å starte bilen trykk på 'A', for å avbryte oppstart, trykk på 'X'");
        var input = Console.ReadLine();
        if (input != null)
        {
            if (input == "A")
            {
                Console.WriteLine("Bilen kjører\n-----");
            }

            if (input == "X")
            {
                Console.WriteLine("Oppstart avbrutt\n-----");
            }
            else if (input != "A" && input != "X") Console.WriteLine("Invalid input"); return;

        }
    }
    public void Comp(Car otherCar)
    {
        List<string> resList = new List<string>();
        if (this.Max_Speed == otherCar.Max_Speed) resList.Add("yes"); else resList.Add("no");
        if (this.Effect == otherCar.Effect) resList.Add("yes");else resList.Add("no");
        if (this.Type == otherCar.Type) resList.Add("yes");else resList.Add("no");
        if (this.color == otherCar.color) resList.Add("yes");else resList.Add("no");
        if (this.Reg_no == otherCar.Reg_no) resList.Add("yes"); else resList.Add("no");

        bool cond = true;

        while (true)
        {
            foreach (string svar in resList)
            {
                if (svar == "yes") cond = true;
                else cond = false;
            }

            Console.WriteLine("Resultat av sammenligning: " + cond + "; ");
            if (cond)
            {
                Console.WriteLine($"Bilene er like\n--------\n");
            }
            else
            {
                Console.WriteLine($"Bilene er ikke like\n--------\n");}
            return;
        }

    }


    public override void Run(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }
}
//reg.nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 