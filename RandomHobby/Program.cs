namespace RandomHobby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] Hobbies = { "a painter", "a homecook", "a runner", "a swimmer", 
                "a crystal collector", "an outdoor person", "a pokerplayer", "a gamer", "a musician" };

            Random random = new Random();
            var randomNumber = random.Next(0, 10);
            Console.WriteLine("Who wants a new hobby?");
            var answer = Console.ReadLine();
            Console.WriteLine($"{answer} is now {Hobbies[randomNumber]}");
           
        }
    }
}