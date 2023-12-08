namespace LagerStyringSys;

public class Lager
{
    


    public List<IProduct> Products { get; set; } = new List<IProduct>();

    public void AddProduct(IProduct? item)
    {

        if (item != null)
        {
            Products.Add(item);
        }
        else Console.WriteLine("duh");
        
     
    }

    public void RemoveProduct(IProduct product)
    {
        Products.Remove(product);
    }

    public void PrintProducts()
    {
        foreach (var product in Products)
        {
            Console.WriteLine("-------");
            product.SkrivUtInfo();
            
        }
    }
}