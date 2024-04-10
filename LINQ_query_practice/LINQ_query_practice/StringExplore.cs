using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace LINQ_query_practice
{
    internal class StringExplore
    {
        public static void People()
        {
            string[] names = ["Marcin", "Adam", "Martyna"];
            DateTime[] dates = [new(1988,  11,  9),  new(1995,  4,  25),
                new(2003,  7,  24)];
            float[] temperatures = [36.6f, 39.1f, 35.9f];

            Console.WriteLine($"{"Name",-8}  {"Birth  date",10} {"Temp.  [C]",11} - > Result");

            for (int i = 0; i < names.Length; i++)
            {
                string line = $"{names[i],-8}  {dates[i],10:dd.MM.yyyy} {temperatures[i],11:F1}  ->  {temperatures[i] switch  //veldig kort og konsis syntax for switch statement!:
                {

                    > 40.0f => "Very  high",

                    > 37.0f => "High",

                    > 36.0f => "Normal",

                    > 35.0f => "Low",

                    _ => "Very  low"

                }}";


                Console.WriteLine(line);


            }


        }
    }
}
