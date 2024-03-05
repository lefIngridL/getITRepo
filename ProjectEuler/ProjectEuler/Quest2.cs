using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Quest2
    {
        internal int start = 1;



        public Quest2()
        {

        }

        public static void Fib()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            int i = 2;
            while ((list[i - 1] + list[i - 2]) < 4000000)
            {
                if (list.Count > 1)
                {
                    //Console.WriteLine("list[i]: " + list[i] + "list[i - 1]: " + list[i - 1]);
                    list.Add(list[i - 1] + list[i - 2]);
                    Console.WriteLine("more than 1 " + list[i]);
                }
                else if (list.Count < 2)
                {
                    list.Add(list[i - 1] + list[i - 1]);
                    Console.WriteLine("less than 2");
                }

                i++;

            }

            int sum = 0;
            list.ForEach(x =>
            {

                if (x % 2 == 0)
                {
                    Console.WriteLine("even: " + x);
                    sum += x;
                }
            });
            Console.WriteLine("sum of even-values terms: " + sum);
            Console.WriteLine("list.Count: " + list.Count);


        }

    }
}
