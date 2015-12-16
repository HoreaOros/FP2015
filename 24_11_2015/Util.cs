using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_2015
{
    class Util
    {
        /// <summary>
        /// Extrage un intreg de la consola
        /// </summary>
        /// <returns>Valoarea extrasa</returns>
        public static int ExtractInt()
        {
            Console.WriteLine("Introduceti un numar natural");
            return ExtractIntHelper();
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

        /// <summary>
        /// Extrage un intreg de la consola
        /// </summary>
        /// <param name="p">Mesajul care se afiseaza</param>
        /// <returns></returns>
        public static int ExtractInt(string p)
        {
            Console.WriteLine(p);


            return ExtractIntHelper();
            
        }


        private static int ExtractIntHelper()
        {
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

        internal static void SelectionSort(int[] v)
        {
            int iMin, aux;
            for (int i = 0; i < v.Length - 1; i++)
            {
                iMin = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[j] < v[iMin])
                    {
                        iMin = j;
                    }
                }
                if (iMin != i)
                {
                    aux = Swap(v, iMin, i);
                }
            }
        }

        private static int Swap(int[] v, int i, int j)
        {
            int aux;
            aux = v[i];
            v[i] = v[j];
            v[j] = aux;
            return aux;
        }

        internal static void InsertionSort(int[] v)
        {
            int j;
            for (int i = 1; i < v.Length; i++)
            {
                j = i;
                while (j > 0 && v[j] < v[j - 1])
                {
                    Swap(v, j, j - 1);
                    j--;
                }
            }
        }
    }
}
