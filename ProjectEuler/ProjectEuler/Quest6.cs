using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Quest6
    {
        public static void Square(int x)
        {
            double sumOfSquares = 0;
            double squareOfSum = 0;
            double sum = 0;
            for (int i = 0; i < x; i++)
            {
                sumOfSquares += Math.Pow((i+1), 2);
                sum += i+1;
            }
            squareOfSum = Math.Pow(sum, 2);
            Console.WriteLine("sum of Squares: " + sumOfSquares + "\n Square of sum: " + squareOfSum + "\n Difference: " + (squareOfSum - sumOfSquares));

        }
    }
}
