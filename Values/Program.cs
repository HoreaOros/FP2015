using System;

namespace Values
{
    enum LunileAnului
    {
        Ianuarie, 
        Februarie, 
        Martie, 
        Aprilie, 
        Mai, 
        Iunie, 
        Iulie, 
        August, 
        Septembrie, 
        Octombrie, 
        Noiembrie, 
        Decembrie
    }
    struct DataCalendaristica
    {
        public int zi;
        public LunileAnului luna;
        public int an;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //DataCalendaristica azi;
            //DataCalendaristica dataNasterii;

            //azi.zi = 3;
            //azi.luna = LunileAnului.Noiembrie;
            //azi.an = 2015;

            //dataNasterii.zi = 5;
            //dataNasterii.luna = LunileAnului.Iulie;
            //dataNasterii.an = 1996;

            //Console.WriteLine("Diferenta dintre cele doua date este: {0}", DiferentaZile(azi, dataNasterii));

            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToLongDateString());

            DateTime d2 = new DateTime(2015, 11, 10);


        }

        private static int DiferentaZile(DataCalendaristica azi, DataCalendaristica dataNasterii)
        {
            int contor = 0;

            while (!DateEgale(azi, dataNasterii))
            {

                azi = ScadOZi(azi);

                contor++;
            }


            return contor;
        }

        private static DataCalendaristica ScadOZi(DataCalendaristica azi)
        {
            if (azi.zi > 1)
            {
                azi.zi--;
            }
            else
            {
                switch (azi.luna)
                {
                    case LunileAnului.Ianuarie:
                        azi.luna = LunileAnului.Decembrie;
                        azi.zi = 31;
                        azi.an--;
                        break;
                    case LunileAnului.Februarie: 
                    case LunileAnului.Aprilie: 
                    case LunileAnului.Iunie: 
                    case LunileAnului.August: 
                    case LunileAnului.Septembrie: 
                    case LunileAnului.Noiembrie: 
                        azi.luna--;
                        azi.zi = 31;
                        break;
                    case LunileAnului.Mai: 
                    case LunileAnului.Iulie: 
                    case LunileAnului.Octombrie: 
                    case LunileAnului.Decembrie:
                        azi.luna--;
                        azi.zi = 30;
                        break;
                    case LunileAnului.Martie:
                        azi.luna = LunileAnului.Februarie;
                        if (Bisect(azi.an))
                            azi.zi = 29;
                        else
                            azi.zi = 28;
                        break;
                    default:
                        break;
                }
            }
            return azi;
        }

        private static bool Bisect(int p)
        {
            if ((p % 4 == 0 && p % 100 != 0) || p % 400 == 0)
            {
                return true;
            }
            else
                return false;
        }

        private static bool DateEgale(DataCalendaristica d1, DataCalendaristica d2)
        {
            if ((d1.zi == d2.zi) && (d1.luna == d2.luna) && (d1.an == d2.an))
            {
                return true;
            }
            return false;
        }
    }
}
