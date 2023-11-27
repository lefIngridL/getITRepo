using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innkapsling
{
    internal class Stats
    {
       
        public int _Numerator { get; private set; }
        public int Sum { get; private set; }

        

        public void AddNumber(int number)
        {
            Sum += number;
            _Numerator++;
        }

        

        public float GetMean()
        {
            return (float)Sum / _Numerator;
        }
    }
}
