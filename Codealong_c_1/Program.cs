namespace Codealong_c_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Race();
        }

        public static void Race()
        {
            Car nr1 = new Car(10, 0);

            while (nr1.Distance < 1001 && nr1.Distance >= 0)
            {
                if (nr1.Distance < 501)
                {
                    Console.WriteLine($"fart: {nr1.Speed}, avstand: {nr1.Distance}");
                    nr1.Speed += 10;
                    nr1.Distance += nr1.Speed;
                }
                else if (nr1.Distance > 500 && nr1.Distance > 0 && nr1.Speed >= 0)
            {
                Console.WriteLine($"fart: {nr1.Speed}, avstand: {nr1.Distance}");

                nr1.Speed -= 10;
                nr1.Distance += nr1.Speed;
            }
            }

            
            //for (int i = 0; i < 51; i++)
            //{
            //    nr1.Speed += 10;
            //    Console.WriteLine($"Meter kjørt: {i} {nr1.Speed}");
            //}

            //while (nr1.Speed > 10)
            //{
            //    nr1.Speed -= 10;
            //    Console.WriteLine(nr1.Speed);
            //}
            

        }
    }
}

//Car race
//Du skal lage en konsollapp med en bil som skal kjøre 1000m.
//Bilen har en start-hastighet på 10m/s
//( en iterasjon i en løkke er et sekund).
//Bilen skal øke farten med 10m/s frem til
//den har kjørt 500m, også skal den senke
//farten med 10m/s igjen frem til den når
//minimumshastigheten sin på 10m/s.
//Når bilen har kommet seg til
//slutt-målet printes det ut til skjermen at bilen er fremme og har parkert.

//    Utvid oppgaven til at du kan lage 2
// biler som kjører om kapp i en løkke,
// der de har en metode som genererer en
// random hastighet til dem mellom 60-200m/s
// som varer en runde. Det er førstemann til å kjøre 10000m