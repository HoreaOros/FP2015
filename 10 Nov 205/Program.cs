using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Nov_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumaSecventa();
            //MaximSecventa();
            SecventaCrescatoare();
        }

        private static void SecventaCrescatoare()
        {
            bool ok = true;
            int a, b;
            // TODO
            a = Util.ExtractInt();
            if (a != 0)
            {
                do
                {
                    b = Util.ExtractInt();
                    if (b != 0)
                    {
                        if (a > b)
                        {
                            ok = false;
                        }
                        a = b;
                    }
                } while (b != 0);

                if (ok)
                {
                    Console.WriteLine("Secventa este ordonata crescator");
                }
                else
                {
                    Console.WriteLine("Secventa nu este ordonata crescator");
                }
            }
            else
            {
                Console.WriteLine("Secventa nu contine nici un numar");
            }
        }

        private static void MaximSecventa()
        {
            int n;
            int maxim = int.MinValue;
            do
            {
                n = Util.ExtractInt();
                if (n != 0)
                {
                    if (n > maxim)
                    {
                        maxim = n;
                    }
                }
            } while (n != 0);
            Console.WriteLine("Maximul este: {0}", maxim);
        }

        private static void SumaSecventa()
        {
            int n;
            int suma = 0;
            do
            {
                n = Util.ExtractInt();
                if (n != 0)
                {
                    suma = suma + n;
                }
            } while (n != 0);
            Console.WriteLine("Suma numerelor este: {0}", suma);
        }
    }
}
