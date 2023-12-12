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

            foreach (Shape shape in Former)
            {
                decimal Areal = shape.AreaCalc();
                Console.WriteLine($"navn: {shape.Name}\nFarge: {shape.Color}\nAreal: {Areal}");
            }
        }
    }
}