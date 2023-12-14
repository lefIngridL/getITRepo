using System.Security.Cryptography.X509Certificates;

namespace ShapeContSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Former = new List<Shape>();
            Former.Add(new Circle("sirkel1", "rød", 10));
            Former.Add(new Circle("sirkel2", "grønn", 5));
            Former.Add(new Rectangle("box1", "Lilla", 3, 5));
            Former.Add(new Rectangle("box2", "Gul", 12, 8));
            Former.Add(new Triangle("spiss1", "Blå", 12, 8));
            Former.Add(new Triangle("spiss2", "Oransje", 6, 9));

            PrintInfo(Former);
            AreaSort(Former);
        }
        static void PrintInfo(List<Shape> Former)
        {
            foreach (Shape shape in Former)
            {
                decimal Areal = shape.AreaCalc();
                Console.WriteLine($"navn: {shape.Name}\nFarge: {shape.Color}\nAreal: {Areal}");
            }
        }

        static void AreaSort(List<Shape> Former)
        {
            decimal num = 0;
            decimal big = Former[0].AreaCalc();
            decimal last = 0;
            foreach (Shape shape in Former)
            {
                decimal current = shape.AreaCalc();
                Console.WriteLine($"Current: {current}");
                
                if(current > big) big = current; 
                Console.WriteLine($"Største hittil: {big}");
                last = big;
                decimal second = 0;
                if (current < last) second = current;
                Console.WriteLine($"den: {second}");
                last = second;
                Console.WriteLine($"hmm: {last}");
            }

            foreach (Shape shape in Former) 
            {

            }
        }
    }
}