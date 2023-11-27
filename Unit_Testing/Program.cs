namespace Unit_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stats = new Stats();
            while (true)
            {
                Console.Write("Skriv tall: ");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                stats.Add(number);
                Console.WriteLine(stats.GetDescription());
            }
        }
    }
}