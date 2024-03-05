using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Code
    {
        internal int total = 1000;
        internal int tre = 3;
        internal int fem = 5;
        public Code() {
            
        }

        public static void Main()
        {
            float[] numbers = new float[1000];
            float sum = 0;
            float[] goalArr = new float[1000];
            for (int i = 0; i < numbers.Length; i++)
            { 
                //Console.WriteLine(i);
                goalArr[i] = Numbers(i);
            }
            foreach (var item in goalArr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            
            for (int i = 0;i < numbers.Length;i++)
            {
                string FB() => ((i / 3) % 1 == 0 || (i / 5) % 1 == 0) ? "Fizz" : "Buzz";
                Console.WriteLine(FB());
            }

        }
        internal static float Numbers(float myNum)
        {
            if ((myNum/3) %1 == 0 || (myNum/5)%1 == 0) {
                return myNum;
            }
            return 0;
        }
    }
}
//fizz/buzz