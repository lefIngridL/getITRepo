using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Quest9
    {
        public static void PyTri()
        {
            double Product = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    double a = Math.Pow(i, 2);
                    double b = Math.Pow(j, 2);
                    double c = a + b;
                    double cRoot = Math.Sqrt(c);


                    if (i + j + cRoot == 1000 && i < j && j < cRoot)
                    {
                        Console.WriteLine("a: " + i + " -- b: " + j + " -- c:" + cRoot + " --- a+b+c = " + (i + j + cRoot));
                        Product = i * j * cRoot;
                        Console.WriteLine("Product a*b*c: "+Product);
                        break;
                    }


                }
            }
        }
    }
}
