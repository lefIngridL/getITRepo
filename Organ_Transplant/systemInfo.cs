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


    public void PrintInfo()
    {
        Console.WriteLine("Mulige blodtyper: ");
        foreach (string type in Bloodtypes)
        {
            Console.WriteLine(type);
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