using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3nPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar natural pozitiv: ");
            string line;

            line = Console.ReadLine();
            int N = int.Parse(line);

            int max = N;
            int lungime = TreiNPlus1(N, ref max);

        }

        private static int TreiNPlus1(int n, ref int maxim)
        {
            int contor = 1;

            maxim = n;
            Console.Write("{0} ", n);
            while (n != 1)
            {
                if (n % 2 == 1)
                    n = 3 * n + 1;
                else
                    n = n / 2;

                if (n > maxim)
                {
                    maxim = n;
                }

                Console.Write("{0} ", n);
                contor++;
            }
            return contor;
        }
    }
}
