using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    struct Box
    {
        public int lungime, latime, inaltime;
        public int Volum()
        {
            return lungime * latime * inaltime;
        }
    }

    enum Color
    {
        Red,
        Green,
        Blue,
        Orange,
        Pink,
        Magenta,
        Cyan
    }
    class Program
    {
        static int c = 0;
        static void Main(string[] args)
        {
            int n = 4, m = 6, r;
            uint ui = 12u;
            byte v1;
            sbyte v2;
            short v3 = 1;
            ushort v4;
            long v5;
            ulong v6;
            float f = 3.14f;
            double d = 3.14;
            decimal dec;
            char c = 'A';

            r = m + n;
            r = m * n;
            r = m % n;

            bool b = m < n;
            r = m << n;
            r = (1 * 2) + 3;  
            b = (m < n) && ((m + 4) > (n / 2));

            r = m / n;
            r = m % n;
            r = (m > n) ? m % n : n % m;
            Console.WriteLine(n);
            Console.WriteLine("{0}, {1}", m, n);

            string line;
            line = Console.ReadLine();
            int input = 0;
            try
            {
                input = int.Parse(line);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Box b1;
            b1.inaltime = 1;
            b1.latime = 2;
            b1.lungime = 3;
            Console.WriteLine("Volumul cutiei este: {0}", b1.Volum());

            Color color = Color.Green;
            switch (color)
            {
                case Color.Red:
                    // ________
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Orange:
                    break;
                case Color.Pink:
                    break;
                case Color.Magenta:
                    break;
                case Color.Cyan:
                    break;
                default:
                    break;
            }

            if (m > n)
            {
                int aux;
                aux = m;
                m = n;
                n = aux;
            }
            else
            {
                line = ";;;;"; 
            }

            int[] v = { -3, 3, 5, 4, 8 };
            int[] w = new int[10];

            int suma = 0;
            for (int index = 0; index < v.Length; index++)
            {
                suma += v[index];
            }


            int numar = 125874;
            Console.WriteLine("Suma cifrelor numarului {0} este {1}", numar, F(numar));
        }

        private static int F(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma = suma + n % 10;
                n /= 10; // n = n / 10;
            }
            return suma;
        }
    }
}
