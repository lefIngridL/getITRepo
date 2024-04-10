using LINQ_query_practice;
using System.Security.Cryptography.X509Certificates;
//Data type value Tuple! :)
using Stats = (int Min, int Max, double Avg);
public class Program
{
    public static void Main(string[] args)
    {
        StringExplore.People();
        Console.WriteLine("Hello, World!");
        Stats results = Calculate(4, 8, 3,5,6,12);
        Console.WriteLine($"Max= {results.Max} / Min= {results.Min} /  Avg= {results.Avg:F2}");
        //

        Stats Calculate(params int[] numbers)
        {
            if (numbers.Length == 0) { return (0, 0, 0); }
            int Min = int.MaxValue;
            int Max = int.MinValue;
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number < Min) { Min = number; }
                if (number > Max) { Max = number; }
                sum += number;
            }
            return(Min, Max, (double)sum / numbers.Length);
        }

        //user defined structs!
        Price priceRegular = new(100, CurrencyEnum.Pln);
        Console.WriteLine(priceRegular);
        Price priceDiscount = priceRegular with { Amount = 50 };
        Console.WriteLine(priceDiscount);
    }
}