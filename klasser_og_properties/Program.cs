namespace klasser_og_properties_pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Pokemon pikachu = new Pokemon(100, 30);
            Console.WriteLine($"Helse: {pikachu.Health}, Alder: {pikachu.Level}");
        }
    }
}