// See https://aka.ms/new-console-template for more information

using Code_jan;
using Code_jan.ROM;


Console.WriteLine("Lag et hus!");
Console.WriteLine("Hvor mange etasjer har huset?");
var EtasjeNRStr = Console.ReadLine();
int EtasjeNr = int.Parse(EtasjeNRStr);
HUS.BuildHouse(EtasjeNr);

//Lag en app som kan bygge et hus.
//Et hus kan bestå av etasjer og rom.
//Brukeren skal kunne velge hva slags type rom den vil legge til om det er bad, kjøkken, soverom eller stue.
//Et hus er ikke ferdig før hver etasje består av nøyaktig 5 rom,
//og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje.
//Når huset er ferdig, skal applikasjonen printe ut informasjon om hvilke rom huset består av.