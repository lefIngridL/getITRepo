namespace Organ_Transplant;

public class Recipient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public string BloodType { get; set; }
    public string GeneGroup { get; set; }
    public string ImuneType { get; set; }
    public Organ FaultyOrgan { get; set; }

    public Recipient(string name, int age, string sex, string bloodType, string geneGroup,string imuneType, Organ faultyOrgan)
    {
        Name = name;
        Age = age;
        Sex = sex;
        BloodType = bloodType;
        GeneGroup = geneGroup;
        ImuneType = imuneType;
        FaultyOrgan = faultyOrgan;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Pasient på venteliste for å motta nytt organ:\nNavn: {Name}\nAlder: {Age}\nKjønn: {Sex}\nBlod type: {BloodType}\nGenetikk: {GeneGroup}\nImmunsystem: {ImuneType}\nSykt organ: {FaultyOrgan.Type}\nFunksjons score sykt organ: {FaultyOrgan.HealthScore}");
    }
}