using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Quest5
    {

        public static void Multi(int x)
        {
            
            bool flag = false;
            double winner = 0;
            double num = 1;
            while (!flag)
            {
                flag = Loop(num, x);
                if (flag) { winner = num; break; }
                num++;
            }
            Console.WriteLine("FLAG: " + flag + "\n Winner: " + winner);
        }

        public static bool Loop(double num, int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (!(num % (i + 1) == 0)) { return false; }
            }
            return true;
        }
    }
}
