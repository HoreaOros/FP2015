using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17_11_2015
{
    class Program
    {
        private static readonly int MaxValue = 100;
        private static readonly int Max = 1000000;
        static void Main(string[] args)
        {
            int[] v;

            v = new int[Max];

            // Initial elementele vectorului de intregi au valoarea zero
            //PrintArray(v);


            // Intializam elementul de pe pozitia i cu patratul lui i
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = i * i;
            }
            //PrintArray(v);

            // Initializam elementele vectorului cu valori citite de la tastatura. 
            //for (int i = 0; i < v.Length; i++)
            //{
            //    v[i] = Util.ExtractInt();
            //}
            //PrintArray(v);

            //int suma = 0;
            //foreach (var item in v)
            //{
            //    suma += item;
            //}
            //Console.WriteLine("Suma valorilor introduse este: {0}", suma);

            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(MaxValue);
            }
            //PrintArray(v, false);

            int[] frecvente = new int[MaxValue];
            foreach (var item in v)
            {
                frecvente[item]++;
            }
            PrintArray(frecvente, true);


            //CountingSortPrint(frecvente);
            StreamReader sr = new StreamReader("Numere.txt");
            int[] valoriDinFisier;

            string line;
            line = sr.ReadLine();
            int n = int.Parse(line);

            valoriDinFisier = new int[n];

            for (int i = 0; i < n; i++)
            {
                line = sr.ReadLine();
                valoriDinFisier[i] = int.Parse(line);
            }

            sr.Close();
        }

        private static void CountingSortPrint(int[] frecvente)
        {
            for (int i = 0; i < frecvente.Length; i++)
            {
                for (int j = 0; j < frecvente[i]; j++)
                {
                    Console.Write("{0} ", i);
                }
            }
        }

        private static void PrintArray(int[] v, bool withIndex)
        {
            if (withIndex == false)
            {
                foreach (int item in v)
                {
                    Console.Write("{0} ", item);
                }
            }
            else
            {
                for (int i = 0; i < v.Length; i++)
                {
                    Console.WriteLine("{0} - {1} = {2:P}", i, v[i], (double)v[i] / Max);
                }
            }
            
        }
    }
}
