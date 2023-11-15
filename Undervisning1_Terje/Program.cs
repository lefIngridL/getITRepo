namespace Undervisning1_Terje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 10;
            string y = $"{x}";
            for(int i = 0 ; i < x ; i++ ) {
            x += i ;

            }
            Console.WriteLine($"er {x} og {y} fortsatt like?");
        }
    }
}