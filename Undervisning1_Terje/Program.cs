namespace Undervisning1_Terje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 10;
            string y = $"{x}";
            for(int i = 0 ; i < 10 ; i++ ) {
            x += i ;

            }
            Console.WriteLine($"er {x} og {y} fortsatt like?");

            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = list1;
            
            for(int i = 0 ;i < 3 ;i++ ) {
                Console.WriteLine(list1[i]);
            }
            list2[1] = 10;  
            for(int i = 0 ;i < 3 ;i++ ) {
                Console.WriteLine(list1[i]);
            }
            
        }
    }
}