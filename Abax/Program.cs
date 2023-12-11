namespace Abax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bil1 = new Car(200,"NF123456", 147,Vehicle_Type.LettKjøretøy , "grønn");
            bil1.PrintInfo("bil1");
            Car bil2 = new Car(195,"NF654321",150, Vehicle_Type.LettKjøretøy, "blå");
            bil2.PrintInfo("bil2");
            bil1.Comp(bil2);
            Plane fly1 = new Plane(null,"LN1234",1000,Vehicle_Type.Jetfly,  30, 2, 10, "jetfly");
            fly1.PrintInfo();
            fly1.Run(fly1);
            bil1.Run(bil1);
            Boat båt = new Boat(30, "ABC123",100, Vehicle_Type.Båt,   500 );
            båt.PrintInfo();
        }
    }//båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.
}
//reg.nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 
//reg. nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy 
//fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly