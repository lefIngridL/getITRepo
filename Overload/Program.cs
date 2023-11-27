namespace Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Greet mygreet = new Greet();
            mygreet.PrintWelcomeMessage();
        }
    }
}