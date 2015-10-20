using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect20Oct
{
    class Program
    {
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
        static void Main(string[] args)
        {
            //Console.WriteLine("1. Maximul a doua numere");
            //Maxim2();

            //Console.WriteLine("2. Maximul a trei numere");
            //Maxim3();

            Console.WriteLine("3. Suma cifrelor unui numar");
            SumaCifre();
        }

        private static void SumaCifre()
        {
            int n, aux;
            n = ExtractInt();

            int sumaCifre = 0;
            int cifra;

            aux = n;
            while (aux > 0)
            {
                cifra = aux % 10;
                sumaCifre = sumaCifre + cifra;
                aux = aux / 10;
            }

            Console.WriteLine("Suma cifrelor numarului {0} este {1}", n, sumaCifre);


        }

        private static void Maxim3()
        {
            int a, b, c;
            a = ExtractInt();
            b = ExtractInt();
            c = ExtractInt();

            //Console.WriteLine("Maximul dintre cele trei numere este: {0}", Math.Max(a, Math.Max(b, c)));

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Maximul este: {0}", a);
                }
                else
                {
                    Console.WriteLine("Maximul este: {0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Maximul este: {0}", b);
                }
                else
                {
                    Console.WriteLine("Maximul este: {0}", c);
                }
            }

        }
        /// <summary>
        /// Determina maximul dintre doua numere
        /// </summary>
        /// <seealso cref="Math.Max"/>
        private static void Maxim2()
        {
            int a, b;
            a = ExtractInt();
            b = ExtractInt();

            if (a > b)
            {
                Console.WriteLine("Maximul este: {0}", a);
            }
            else
            {
                Console.WriteLine("Maximul este: {0}", b);
            }

            //Console.WriteLine("Maximul este: {0}", Math.Max(a, b));
        }
    }
}
