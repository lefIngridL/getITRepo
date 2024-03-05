using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Quest3
    {
        public long Number { get; set; }
        public static void Prime(long Number)
        {
            List<long> list = new List<long>();
            List<long> divlist = new List<long>();
            int div = 2;
            for (int i = 0; i < 10000; i++)
            {
                if (Number % div == 0)
                {
                    list.Add(Number);
                    divlist.Add(div);
                    Number = Number / div;
                    Console.WriteLine("Number /div: " + Number / div + ($"div: {div}"));
                }
                else
                {
                    div++;
                   // Console.WriteLine(Number);
                }
            }
            list.ForEach(x => Console.WriteLine("listetall: "+ x));
            divlist.ForEach(x => Console.WriteLine("Prime factors: "+ x));

        }
    }
}
