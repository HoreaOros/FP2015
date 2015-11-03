using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0.0;
            int n = 1000000;

            for (int i = 0; i < n; i++)
            {
                suma = suma + 0.01;
            }
            Console.WriteLine("Suma este: {0}", suma);

            double na = 1.0 / 0;

            Console.WriteLine(na);
        }
    }
}
