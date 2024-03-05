using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Quest7
    {
        public static void Prime()
        {
            double num = 0;
            double primes = 0;
            bool flag = false;
            double final = 0;

            while (primes < 10001)
            {
                flag = Loop(num);
                if (flag)
                {
                    if (num != 1)
                    {
                        primes++;
                        //Console.WriteLine("Prime: " + num + " -- Prime counter: " + primes);
                    }
                    if (primes == 10001)
                    {
                        final = num;
                        break;
                    }
                }

                num++;
            }
            Console.WriteLine("10001th Prime number: " + final);
        }
        public static bool Loop(double num)
        {
            bool flag = false;
            for (int j = 0; j < num; j++)
            {
                if (num != j && j != 1 && num % j == 0)
                {
                    return false;
                }
                else { flag = true; }
            }
            return flag;
        }
    }
}
