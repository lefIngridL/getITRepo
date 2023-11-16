using System.Security.Cryptography.X509Certificates;

namespace what_does_this_code_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                string textL = text.ToLower();
                foreach (var character in textL ?? string.Empty)
                {
                    Console.WriteLine(character);

                    counts[(int)character]++;

                }
                int total = 0;
                foreach (int vals in counts)
                {
                    total += vals;
                }
                Console.WriteLine(total);

                for (var i = 0; i < range; i++)
                {

                    if (counts[i] > 0)
                    {
                        decimal teller = (decimal)counts[i];
                        decimal nevner = (decimal)total;
                        decimal per = (teller/nevner)*100;
                        float percent = (float)Math.Round(per);
                        var character = (char)i;
                        string output = character + "-" + percent.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}