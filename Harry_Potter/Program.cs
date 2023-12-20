using System;
using Harry_Potter.Entity;
using Harry_Potter.Items;
using Harry_Potter.Items.Money;
using Harry_Potter.Items.Pets;
using Harry_Potter.Items.Pets.Cats;
using Harry_Potter.Items.Pets.Cats.CatFur;
using Harry_Potter.Items.Wands;
using Harry_Potter.Magic;
using Harry_Potter.Places;

namespace Harry_Potter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game.Start();
            //var toto = new Cat(10,Coinage.SilverSickle,"wanda",6, FurColor.Brown, FurLength.Long, FurPatterns.Tabby, FurQuality.DoubleCoat);
            //toto.PrintInfo();
            //var bibi = new ForestCat(8, Coinage.SilverSickle, "Bibi", 2, FurColor.Black,
            //    FurPatterns.Tuxedo);
            //bibi.PrintInfo();
        }



    }
}