namespace Organ_Transplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MatchDonor();
        }

        static void MatchDonor()
        {
            Organ sykNyre = new Organ("Nyre", 0.09);
            Organ friskNyre = new Organ("Nyre", 0.98);
            Donor kåre = new Donor("Kåre", 32, "MALE", "AB", "Haplogruppe D", "MHC class I",friskNyre);
            Recipient bernt = new Recipient("Bernt", 41, "MALE", "AB", "Haplogruppe D" ,"MHC class I", sykNyre);
            
            bernt.PrintInfo();
            kåre.PrintInfo();
            systemInfo blod = new systemInfo();

            blod.PrintInfo();

        }
    }
}
//Oppgave: Organ transplant!
//    Det har vært en akutt ulykke og Bernt ligger på sykehuset.

//    Han trenger en ny Nyre!

//Heldigvis har fetteren hans Kåre to sunne Nyrer,
//og det er utført tester som tilsier at Kåre kan
//gi bort en av nyrene til Bernt og det vil være en
//høy suksessrate for overlevelse!

//Hjelp Bernt med å overleve!

//Finn ut hva vi kan lage som objekter,
//og hva man kan lage som metoder i dette tilfellet.

//    Lag gjerne Consoll.WriteLine()
// -statements i koden slik at man ser hva som skjer!