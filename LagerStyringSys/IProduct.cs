namespace LagerStyringSys;

public interface IProduct
{
        string Navn { get; set; }
        double Pris { get; set; }

        void SkrivUtInfo();
    
}