namespace Organ_Transplant;

public class systemInfo
{
    public List<string> Bloodtypes = new List<string>()
    {
        "O+","O-","A+","A-","B+","B-","AB+","AB-"
    };
    public List<string> ImmuneTypes = new List<string>()
    {
        "MHC class I",
        "MHC class II"
    };

    public List<string> HaploGroups = new List<string>()
    {
        "A", "B", "C", "CZ", "D", "E", "F", "G", "H", "HV", "I", "J", "pre-JT", "JT", "K", "L0", "L1", "L2", "L3", "L4", "L5", "L6", "M", "N", "P", "Q", "R", "R0", "S", "T", "U", "V", "W", "X", "Y", "Z"
    };

    public List<string> Gender = new List<string>()
    {
        "MALE", "FEMALE"
    };
    public void PrintInfo()
    {
        Console.WriteLine("Mulige blodtyper: ");
        foreach (string type in Bloodtypes)
        {
            Console.WriteLine(type);
        }
        
    }

    public void PrintHaplo()
    {
        Console.WriteLine("Liste over haplogrupper:");
        foreach (var haploGroup in HaploGroups)
        {
            Console.WriteLine(haploGroup);
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