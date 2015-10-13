using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Teste de paritate");
            P1();

            Console.WriteLine("2. Suma primelor n numere naturale nenule");
            P2();

            Console.WriteLine("3. Algoritmul lui Euclid");
            Euclid();
        }

        private static void Euclid()
        {
            int a, b, r, ca, cb; ;

            a = ExtractInt();
            b = ExtractInt();

            ca = a;
            cb = b;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("Cel mai mare divizor comun al numerelor {0} si {1} este {2}", ca, cb, a);
        }

        private static void P2()
        {
            int n = 0;
            n = ExtractInt();

            Console.WriteLine("Suma numerelor de la 1 la {0} este {1}", n, n * (n + 1) / 2);
        }

        private static int ExtractInt()
        {
            Console.WriteLine("Introduceti un numar natural: ");

            string line;
            line = Console.ReadLine();

            int n = 0;

            try
            {
                n = Int32.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Something went wrong. This is really embarassing! We'll do our best to address this issue in a future version of our code.");
            }

            return n;
        }

        private static void P1()
        {
            int n = 0;

            n = ExtractInt();

            if (n % 2 == 0)
            {
                Console.WriteLine("Numarul introdus este par.");
            }
            else
            {
                Console.WriteLine("Numarul introdus este impar.");
            }

        }
    }
}
