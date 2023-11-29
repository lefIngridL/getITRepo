namespace Organ_Transplant;

public class Donor
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public double Heigth { get; set; }
    public double Weigth { get; set; }
    public string BloodType { get; set; }
    public string GeneGroup { get; set; }
    public string ImuneType { get; set; }
    public Organ DonOrgan { get; set; }

    public Donor(string name, int age, string sex, double heigth, double weigth, string bloodType, string geneGroup, string imuneType, Organ donOrgan)
    {
        Name = name;
        Age = age;
        Sex = sex;
        Heigth = heigth;
        Weigth = weigth;
        BloodType = bloodType;
        GeneGroup = geneGroup;
        ImuneType = imuneType;
        DonOrgan = donOrgan;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Potensiell organ donor:\nNavn: {Name}\nAlder: {Age}\nKjønn: {Sex}\nHøyde: {Heigth}\nVekt: {Weigth}\nBlod type: {BloodType}\nGenetikk: {GeneGroup}\nImmuntype: {ImuneType}\ndonor organ: {DonOrgan.Type}\nFunksjons score organ: {DonOrgan.HealthScore}");
    }

    
}