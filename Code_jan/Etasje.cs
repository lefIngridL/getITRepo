using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_jan.ROM;

namespace Code_jan
{
    public class Etasje
    {

        public Rom Rom1 { get; set; }
        public Rom Rom2 { get; set; }
        public Rom Rom3 { get; set; }
        public Rom Rom4 { get; set; }
        public Rom Rom5 { get; set; }

        public Rom[] AllRooms { get; set; }


        public Etasje(Rom rom1, Rom rom2, Rom rom3, Rom rom4, Rom rom5)
        {
            Rom1 = rom1;
            Rom2 = rom2;
            Rom3 = rom3;
            Rom4 = rom4;
            Rom5 = rom5;
            
            AllRooms = new Rom[5]
            {
                Rom1, Rom2, Rom3, Rom4, Rom5
            };
        }

        public void PrintEtasje()
        {
            foreach (var allRoom in AllRooms)
            {
                allRoom.PrintUt();
            }
        }
    }
}
