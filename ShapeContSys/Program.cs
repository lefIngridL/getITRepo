using System.Security.Cryptography.X509Certificates;
using ShapeContSys.Shapes;

using ShapeContSys.Shapes;

namespace ShapeContSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Former = new(){
            new Circle("sirkel1", "rød", 10),
            new Circle("sirkel2", "grønn", 5),
            new Rectangle("box1", "lilla", 3, 5),
            new Rectangle("box2", "gul", 12, 8),
            new Triangle("spiss1", "blå", 12, 8),
            new Triangle("spiss2", "oransje", 6, 9),
            };
            PrintInfo(Former);
            TotalArea(Former);
            AreaSort(Former);
            while (true)
            {
                Console.WriteLine("\n\nSkriv inn en farge:\n\n");
                string input = Console.ReadLine();
                ColorSort(Former, input);
            }

        }
        static void PrintInfo(List<Shape> Former)
        {
            Console.WriteLine("-----Informasjon om formene-----");
            foreach (Shape shape in Former)
            {
                shape.PrintShape();
            }
        }

        static void TotalArea(List<Shape> Shapes)
        {
            double Total = 0;
            foreach (Shape shape in Shapes)
            {
                double value = shape.AreaCalc();
                Total += value;
            }

            Console.WriteLine($"\n\n-----Totalt Areal av alle former-----:\n{Math.Round(Total, 2)} kvadrat cm.");
        }

        static void AreaSort(List<Shape> Former)
        {
            double[] arr = new double[Former.Count];
            int N = 0;
            foreach (Shape shape in Former)
            {
                arr[N] = shape.AreaCalc();
                N++;
            }
            Array.Reverse(arr);
            Console.WriteLine("\n-----Formenes Areal fra minst til størst------:\n");
            foreach (var d in arr)
            {
                Console.Write(d + "  ");
            }

        }

        static void ColorSort(List<Shape> former, string color)
        {
            Console.WriteLine($"\nListe over former med fargen {color}:\n\n");
            foreach (var shape in former)
            {
                if (shape.Color == color) shape.PrintShape();
            }

        }


    }
}