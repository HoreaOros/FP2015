using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_2015
{
    class Util
    {
        /// <summary>
        /// Extrage un intreg de la consola
        /// </summary>
        /// <returns>Valoarea extrasa</returns>
        public static int ExtractInt()
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
        /// <summary>
        /// Extrage un numar real in simpla precizie de la consola
        /// </summary>
        /// <returns>Valoarea extrasa</returns>
        public static float ExtractFloat()
        {
            Console.WriteLine("Introduceti un numar real in simpla precizie: ");

            string line;
            line = Console.ReadLine();

            float f = 0;

            try
            {
                f = float.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Something went wrong. This is really embarassing! We'll do our best to address this issue in a future version of our code.");
            }

            return f;
        }
        /// <summary>
        /// Extrage un numar real in dubla precizie de la consola
        /// </summary>
        /// <returns>Valoarea extrasa</returns>
        public static double ExtractDouble()
        {
            Console.WriteLine("Introduceti un numar real in dubla precizie: ");

            string line;
            line = Console.ReadLine();

            double n = 0;

            try
            {
                n = double.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Something went wrong. This is really embarassing! We'll do our best to address this issue in a future version of our code.");
            }

            return n;
        }
    }
}
