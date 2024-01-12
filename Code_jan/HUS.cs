using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_jan.ROM;

namespace Code_jan
{

    public static class HUS
    {



        public static void BuildHouse(int floors)
        {
            Console.WriteLine($"\n----Huset skal ha {floors} etasjer.----\n");
            Etasje[] EtasjeList = new Etasje[floors];


            int num = 0;
            foreach (var Level in EtasjeList)
            {
                Rom[] RomList = new Rom[5];
                RomList = DefineRooms(num, RomList);
                EtasjeList[num] = new Etasje(RomList);
                num++;
                if (num >= 5)
                {
                    num = 0;
                }
                Console.WriteLine("----------------------Er vi tilbake?");
                foreach (var rom in RomList)
                {
                    //Console.Write(rom.Room);
                    rom.PrintUt();
                }
            }


            
        }

        public static Rom[] DefineRooms(int num, Rom[] RomList)
        {

            int numL = 0;
            foreach (var Room in RomList)
            {
                bool cont = true;
                while (cont)
                {
                    Console.WriteLine($"Velg romtype for rom nr. {numL + 1} i etasje {num} ");
                    Console.WriteLine("skriv inn nr for å velge rom:\n1: bad \n2: kjøkken \n3: soverom\n4: stue");
                    var romvalg = Console.ReadLine();
                    Rom defined = Choosening(romvalg, RomList, numL);
                    if (defined != null)
                    {
                        RomList[numL] = defined;
                        cont = false;
                    }
                }
                Console.WriteLine("\n-------\n");
                int tell = 0;
                foreach (var rom2 in RomList)
                {
                    if (RomList[tell] != null)
                    {
                        Console.WriteLine(rom2.Room.ToString());
                    }
                    tell++;
                    if (tell == 5)
                    {
                        tell = 0;
                    }

                }
                Console.WriteLine("\n-------\n");
                numL++;

            }

            return RomList;
        }

        public static Rom Choosening(string romvalg, Rom[] RomList, int numL)
        {
            switch (romvalg)
            {
                case "1":
                    int tell = 0;
                    bool same = false;
                    Rom value = null;
                    foreach (var rom1 in RomList)
                    {
                        if (RomList[tell] != null && RomList[tell].Room == Romtype.Bad && tell != numL)
                        {
                            Console.WriteLine("\n-----Ikke mer enn ett Bad per etasje!-----\n");
                            return null;
                        }
                        else
                        {
                            RomList[numL] = new Rom(Romtype.Bad);
                            value = RomList[numL];
                        }

                        tell++;
                    }

                    return value;
                case "2":
                    bool same2 = false;
                    Rom value2 = null;
                    int tell2 = 0;
                    foreach (var rom2 in RomList)
                    {
                        if (RomList[tell2] != null && RomList[tell2].Room == Romtype.Kjøkken && tell2 != numL)
                        {
                            Console.WriteLine("\n-----Ikke mer enn ett Kjøkken per etasje!-----\n");
                            return null;
                        }
                        else
                        {
                            RomList[numL] = new Rom(Romtype.Kjøkken);
                            value2 = RomList[numL];
                        }

                        tell2++;
                    }

                    return value2;
                case "3":
                    int tell3 = 0;
                    RomList[numL] = new Rom(Romtype.Soverom);
                    return RomList[numL];
                    break;
                case "4":
                    int tell4 = 0;
                    RomList[numL] = new Rom(Romtype.stue);
                    return RomList[numL];
                    break;
                default:
                    Console.WriteLine("\n----Invalid Input!----\n");
                    return null;
                    break;
            }
        }


    }
}
