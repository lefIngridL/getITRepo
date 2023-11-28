namespace Organ_Transplant;

public class Donor
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public string BloodType { get; set; }
    public string GeneGroup { get; set; }
    public string ImuneType { get; set; }
    public Organ DonOrgan { get; set; }

    public Donor(string name, int age, string sex, string bloodType, string geneGroup, string imuneType, Organ donOrgan)
    {
        Name = name;
        Age = age;
        Sex = sex;
        BloodType = bloodType;
        GeneGroup = geneGroup;
        ImuneType = imuneType;
        DonOrgan = donOrgan;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Potensiell organ donor:\nNavn: {Name}\nAlder: {Age}\nKjønn: {Sex}\nBlod type: {BloodType}\nGenetikk: {GeneGroup}\nImmuntype: {ImuneType}\ndonor organ: {DonOrgan.Type}\nFunksjons score organ: {DonOrgan.HealthScore}");
    }
}