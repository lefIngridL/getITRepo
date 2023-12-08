namespace LagerStyringSys
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Lager storage = new Lager();
            Klær bukse = new Klær("M", "Jeans", 500);
            Klær genser = new Klær("L", "Hettegenser", 700);
            Klær kjole = new Klær("small", "midi-kjole", 1200);

            Matvare melk = new Matvare("30.12.23", "helmelk", 28);
            Matvare brød = new Matvare("14.12.23", "grovbrød", 40);

            Elektronikk telefon = new Elektronikk(24, "samsung galaxy", 3500);
            Elektronikk laptop = new Elektronikk(24, "Lenovo", 10000);

            storage.AddProduct(bukse);
            storage.AddProduct(genser);
            storage.AddProduct(kjole);
            storage.AddProduct(melk);
            storage.AddProduct(brød);
            storage.AddProduct(telefon);
            storage.AddProduct(laptop);

            storage.RemoveProduct(kjole);

            storage.PrintProducts();
        }
    }
}