namespace Organ_Transplant;

public class systemInfo
{
    private readonly List<string> bloodTypes = new List<string>()
    {
        "O+","O-","A+","A-","B+","B-","AB+","AB-"
    };
    private readonly List<string> immuneTypes = new List<string>()
    {
        "MHC class I",
        "MHC class II"
    };

    private readonly List<string> haploGroups = new List<string>()
    {
        "A", "B", "C", "CZ", "D", "E", "F", "G", "H", "HV", "I", "J", "pre-JT", "JT", "K", "L0", "L1", "L2", "L3", "L4", "L5", "L6", "M", "N", "P", "Q", "R", "R0", "S", "T", "U", "V", "W", "X", "Y", "Z"
    };

    private readonly List<string> gender = new List<string>()
    {
        "MALE", "FEMALE"
    };

    private readonly List<string> organs = new List<string>()
    {
        "Hjerte", "Tarmer" ,"Nyre" ,"Lever" ,"Lunge","pancreas"
    };

    public IReadOnlyList<string> BloodTypes => bloodTypes;
    public IReadOnlyList<string> ImmuneTypes => immuneTypes;
    public IReadOnlyList<string>  HaploGroups => haploGroups;
    public IReadOnlyList<string>  Gender => gender;

    public IReadOnlyList<string> Organs => organs;

    public void PrintInfo()
    {
        Console.WriteLine("Mulige blodtyper: ");
        foreach (string type in BloodTypes)
        {
            Console.WriteLine(type);
        }
        
    }

    public void PrintHaplo()
    {
        int index = 0;
        Console.WriteLine("Liste over haplogrupper:");
        foreach (var haploGroup in HaploGroups)
        {
            index ++;
            Console.WriteLine($"nr.{index} {haploGroup}, ");
        }
    }

    public void PrintOrgan()
    {
        Console.WriteLine("Liste over mulige donor organer:");
        foreach (var organ in Organs)
        {
            Console.WriteLine(organ);
        }
    } 
}

//O positive: 35%
//O negative: 13%
//A positive: 30%
//A negative: 8%
//B positive: 8%
//B negative: 2%
//AB positive: 2%
//AB negative: 1%