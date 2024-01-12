using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_jan.ROM;

namespace Code_jan
{
    internal class Etasje
    {
        public Rom[] AllRooms { get; set; }

        public Etasje(Rom[] allRooms)
        {
            AllRooms = allRooms;
        }
    }
}
