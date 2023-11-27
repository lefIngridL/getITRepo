namespace StudentAdmSys;

public class Fag
{
    public string Fagkode { get; set; }
    public string FagNavn { get; set; }
    public int AntallStudiepoeng { get; set; }

    public Fag(string fagkode, string fagNavn, int antallStudiepoeng)
    {
        Fagkode = fagkode;
        FagNavn = fagNavn;
        AntallStudiepoeng = antallStudiepoeng;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Faginformasjon:\nFagkode: {Fagkode}\nFagnavn: {FagNavn}\nAntall Studiepoeng: {AntallStudiepoeng}");
    }
}

