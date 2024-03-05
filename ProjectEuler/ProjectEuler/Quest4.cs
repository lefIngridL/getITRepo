using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Quest4
    {

        public static void Pali()
        {
           
           
            int highestPalindrome = 0;

            for (int x = 100; x < 1000; x++)
            {

                for (int y = 100; y < 1000; y++)
                {
                    int num = x * y;
                    if (Check(num) && num > highestPalindrome)
                    {
                        highestPalindrome = num;
                    }
                }
            }
            Console.WriteLine("Highest Palindrome product of two three digit numbers: " + highestPalindrome);

        }

        public static bool Check(int num)
        {
            string numStr = num.ToString();
            int left = 0;
            int right = numStr.Length - 1;
            while (left < right)
            {
                if (numStr[left] != numStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
            
        }

    }
}
