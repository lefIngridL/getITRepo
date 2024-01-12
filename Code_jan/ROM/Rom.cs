using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_jan.ROM
{
    public class Rom
    {

        public Romtype? Room { get; set; }

        public Rom(Romtype? room)
        {
            Room = room;
        }

        public Rom()
        {

        }

        public void PrintUt()
        {
            Console.WriteLine(this.Room);
        }
    }
}
