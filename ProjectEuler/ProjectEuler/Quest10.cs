using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //svar sum alle primtall under 2 000 000: 142913828922.
    internal class Quest10
    {
        public static void Prime()
        {
            double num = 2;
            double primes = 0;
            double flag = 0;

            double primeSum = 0;
            while (num < 2000000)
            {
                //Console.WriteLine("pre primeSum: "+ primeSum);
                flag = Loop(num, primeSum);
                //Console.WriteLine("flag: "+flag); 

                if (primeSum != flag)
                {
                    primeSum = flag;
                    Console.WriteLine(primeSum);
                }


                //if (flag)
                //{
                //    if (num != 1)
                //    {

                //        primeSum += num;

                //        primes++;
                //        Console.WriteLine("Prime: " + num + " -- Prime counter: " + primes);
                //    }
                //}

                num++;
            }
            //Console.WriteLine("10001th Prime number: " + final);
        }
        public static double Loop(double num, double sum)
        {
            bool flag = false;
            for (int j = 0; j < num; j++)
            {
                if (num != j && j != 1 && num % j == 0)
                {
                    flag = false;
                    break;
                }
                else { flag = true; }
            }
            if (flag)
            {
                sum += num;
                //Console.WriteLine("num: "+num +"\n sum: "+sum);
            }
            return sum;
        }
    }
}
