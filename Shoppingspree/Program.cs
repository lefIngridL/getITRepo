namespace Shoppingspree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clothingItem = new ClothingItem("T-shirt", 2, 400, "blå", Size.L);
            var electronicItem = new ElectronicItem("T-shirt", 2, 400, 20, 12);

            List<ISellable> sellables = new List<ISellable>
            {
                clothingItem, electronicItem
            };

            double Total = 0;
            foreach (var sellable in sellables)
            {
                Total += sellable.SinglePrice();
            }
            Console.WriteLine(Total);
        }
    }
}
//Lag en base klasse som heter “InventoryItem” hvor du har info om itemets navn, antall og pris.
//Lag to klasser til, ClothingItem og ElectronicItem.
//Disse skal ha informasjon om størrelse og farge f.eks på klær og f.eks forsikringsinformasjon
//og spenning på det elektriske.
//La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris.
//Lag et interface ISellable som har en funksjon som kalkulerer pris.
//Implementer dette interfacet i ClothingItem og ElectronicItem
//    Lag noen forskjellige items for å sjekke at det fungerer som tenkt.