using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    public class Stats
    {
        public int Count { get; private set; } = 0;
        public  int Sum { get; private set; } = 0;
        public int? Max { get; private set; } = null;
        public int? Min { get; private set; } = null;
        public float Mean = 0;
       
        public void Add(int number)
        {

            if (Max == null || number > Max) { Max = number; }
            
            if (Min == null || number < Min) { Min = number; }
            Count++;
            Sum += number;
            Mean = (float)Sum/ Count;
            
        }
        public string GetDescription()
        {
            return
                Format("Antall tall", Count) +
                Format("Sum", Sum) +
                Format("Max", Max.Value) +
                Format("Min", Min.Value) +
                Format("Gjennomsnitt", Mean);
        }

        private static string Format(string label, float? number)
        {
            return number == null? string.Empty :
            FormatImpl(label, number.Value.ToString("####.##"));
        }
        private static string Format(string label, int? number)
        {
            if (number == null) { return string.Empty; }
            return FormatImpl(label, number.Value.ToString("####"));
        }
        private static string FormatImpl(string label, string number)
        {
            return label.PadRight(
                12, ' ')
                +": "
                + number
                + '\n';
        }
    }
}
