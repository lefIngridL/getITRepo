namespace Organ_Transplant;

public class Recipient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public double Heigth { get; set; }
    public double Weigth { get; set; }
    public string BloodType { get; set; }
    public string GeneGroup { get; set; }
    public string ImuneType { get; set; }
    public Organ FaultyOrgan { get; set; }

    public Recipient(string name, int age, string sex, double heigth, double weigth, string bloodType, string geneGroup, string imuneType, Organ faultyOrgan)
    {
        Name = name;
        Age = age;
        Sex = sex;
        Heigth = heigth;
        Weigth = weigth;
        BloodType = bloodType;
        GeneGroup = geneGroup;
        ImuneType = imuneType;
        FaultyOrgan = faultyOrgan;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Pasient på venteliste for å motta nytt organ:\nNavn: {Name}\nAlder: {Age}\nKjønn: {Sex}\nHøyde: {Heigth}\nVekt: {Weigth}\nBlod type: {BloodType}\nGenetikk: {GeneGroup}\nImmunsystem: {ImuneType}\nSykt organ: {FaultyOrgan.Type}\nFunksjons score sykt organ: {FaultyOrgan.HealthScore}");
    }

    public void Compare(Recipient other, Donor donor)
    {
        int matchPoints = 0;
        int total = 7;
        double weigthDiff = Math.Abs(donor.Weigth - other.Weigth);
        double heigthDiff = Math.Abs(donor.Heigth - other.Heigth);
        int AgeDiff = Math.Abs(donor.Age - other.Age);
        double H_Diff_lim_cm = 10;
        double W_Diff_lim_kg = 5;
        int Age_Diff_lim_Y = 10;
        Console.WriteLine(weigthDiff);
        Console.WriteLine(heigthDiff);
        if (other.ImuneType == donor.ImuneType)
        {
            matchPoints++;

        }
        Console.WriteLine(other.ImuneType + "/" + donor.ImuneType);
        if (other.BloodType == donor.BloodType)
        {
            matchPoints++;

        }
        Console.WriteLine(other.BloodType + "/" + donor.BloodType);
        if (other.GeneGroup == donor.GeneGroup)
        {
            matchPoints++;

        }
        Console.WriteLine(other.GeneGroup + "/" + donor.GeneGroup);
        if (other.FaultyOrgan.Type == donor.DonOrgan.Type)
        {
            matchPoints++;

        }
        Console.WriteLine(other.FaultyOrgan.Type + "/" + donor.DonOrgan.Type);
        if (AgeDiff <= Age_Diff_lim_Y)
        {
            matchPoints++;

        }
        Console.WriteLine($"mottaker alder: {other.Age}  / giver alder: {donor.Age}");
        if (heigthDiff <= H_Diff_lim_cm)
        {
            matchPoints++;

        }
        Console.WriteLine($"mottaker høyde: {other.Heigth}cm /   giver høyde: {donor.Heigth}cm");
        if (weigthDiff <= W_Diff_lim_kg)
        {
            matchPoints++;

        }
        Console.WriteLine($"mottaker vekt:{other.Weigth}kg / giver vekt: {donor.Weigth}kg ");
        Console.WriteLine(matchPoints + "/" + total);

        if (matchPoints > 5)
        {
            Console.WriteLine($"Det er en god Match. {matchPoints} av {total} mulige poeng");
        }
    }

    public Donor Add_Donor()
    {
        Console.Clear();
        systemInfo info = new systemInfo();
        Console.WriteLine("angi Navn på ny donor:");
        string? navn = Console.ReadLine();
        Console.WriteLine($"ny Donors navn er {navn}");

        Console.Clear();
        Console.WriteLine("angi Alder ny donor: ");
        string? ageStr = Console.ReadLine();
        int age = Convert.ToInt32(ageStr);
        Console.WriteLine($"{navn}'s alder er {age}år");


        string sex = String.Empty;
        while (sex == String.Empty)
        {
            Console.Clear();
            Console.WriteLine("angi kjønn ny donor, tast '1' for 'MALE', tast '2' for 'FEMALE'");
            string? sexStr = Console.ReadLine();
            int sexInt = Convert.ToInt32(sexStr);
            if (sexInt == 1 || sexInt == 2)
            {

                sex = info.Gender[sexInt - 1];
                Console.WriteLine($"kjønnet til {navn} er: {sex}");

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        Console.Clear();
        Console.WriteLine("angi høyde ny donor (i cm):");
        string? heigthStr = Console.ReadLine();
        int heigth = Convert.ToInt32(heigthStr);
        Console.WriteLine($"ny Donor {navn} er {heigth}cm høy.");

        Console.Clear();
        Console.WriteLine($"angi vekt ny donor {navn} (i kg, heltall)");
        string? weigthStr = Console.ReadLine();
        int weigth = Convert.ToInt32(weigthStr);
        Console.WriteLine($"ny Donor {navn} veier {weigth}kg");

        Console.Clear();
        Console.WriteLine("angi blodtype ny donor");
        systemInfo blod = new systemInfo();
        blod.PrintInfo();


        string? bloodType = String.Empty;
        while (bloodType == String.Empty)
        {

            Console.WriteLine("oppgi et tall (1-8) for å velge blodtype fra listen over");
            string? bloodTypeStr = Console.ReadLine();
            int bloodTypeInt = Convert.ToInt32(bloodTypeStr);

            if (bloodTypeInt > 0 && bloodTypeInt < 9)
            {
                bloodType = info.BloodTypes[bloodTypeInt - 1];
                Console.WriteLine($"Du valgte nr {bloodTypeInt}. {navn}'s bloodtype er: {bloodType}");
            }
            else { Console.WriteLine("Invalid input; try again"); }
        }


        Console.Clear();
        info.PrintHaplo();
        string? geneGroup = String.Empty;
        while (geneGroup == String.Empty)
        {

            Console.WriteLine($"angi haplogruppe ny donor som tall 1-{info.HaploGroups.Count}");
            string? geneGroupStr = Console.ReadLine();
            int geneGroupInt = Convert.ToInt32(geneGroupStr);

            if (geneGroupInt > 0 && geneGroupInt <= info.HaploGroups.Count)
            {
                geneGroup = info.HaploGroups[geneGroupInt - 1];
                Console.WriteLine($"Du valgte nr. {geneGroupInt}. {navn}'s Haplogruppe er: {geneGroup}");
            }
            else
            {
                Console.WriteLine("Invalid input; try again");
            }
        }


        Console.Clear();
        string? imuneType = String.Empty;
        while (imuneType == String.Empty)
        {

            Console.WriteLine($"angi MHC klasse ny donor {navn}; tast '1' for '{info.ImmuneTypes[0]}' og tast '2' for '{info.ImmuneTypes[1]}' ");
            string? imuneTypeStr = Console.ReadLine();
            int imuneTypeInt = Convert.ToInt32(imuneTypeStr);
            if (imuneTypeInt > (int)0 && imuneTypeInt < (int)3)
            {
                imuneType = info.ImmuneTypes[imuneTypeInt - 1];
                Console.WriteLine($"Du har valgt nr. {imuneTypeInt}. {navn} har {imuneType}");
            }
            else
            {
                Console.WriteLine("Invalid input; try again");

            }
        }
        Console.Clear();
        string? donOrgan_type = String.Empty;
        while (donOrgan_type == String.Empty)
        {

            Console.WriteLine("velg type donor Organ fra listen som et heltall (1-6):");
            info.PrintOrgan();
            string? donOrgan_typeStr = Console.ReadLine();
            int donOrgan_typeInt = Convert.ToInt32(donOrgan_typeStr);
            if (donOrgan_typeInt > (int)0 && donOrgan_typeInt < (int)7)
            {
                donOrgan_type = info.Organs[donOrgan_typeInt - 1];
                Console.WriteLine($"Du valgte nr. {donOrgan_typeInt}. Mulig donor Organ fra pasient {navn} er {donOrgan_type}");
            }
        }

        bool control = true;
        double donOrgan_health = 0;

        while (control)
        {
            Console.Clear();
            Console.WriteLine("angi helsescore for donor Organ som tall mellom 0 og 1:");
            string? donOrgan_healthStr = Console.ReadLine();
            double donOrgan_health_con = Convert.ToDouble(donOrgan_healthStr);
            if (donOrgan_healthStr != null && donOrgan_health_con > (double)0 && donOrgan_health_con < (double)1)
            {
                donOrgan_health = Convert.ToDouble(donOrgan_healthStr);
                Console.WriteLine($"Helsescore for {navn}'s {donOrgan_type} er {donOrgan_health}");
                control = false;
            }
            else
            {
                Console.WriteLine("Invalid input; try again");
            }
        }
        Console.Clear();
        Organ newOrgan = new Organ($"{donOrgan_type}", donOrgan_health);
        Donor newDonor = new Donor($"{navn}", age, $"{sex}", heigth, weigth, $"{bloodType}", $"{geneGroup}", $"{imuneType}", newOrgan);
        return newDonor;
    }
}