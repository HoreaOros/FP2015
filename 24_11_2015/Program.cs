using System;
using System.Collections.Generic;

namespace _24_11_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v;

            int n;

            n = Util.ExtractInt("Introduceti dimensiunea vectorului");

            v = new int[n]; // toate elementele se intializeaza la zero

            // initializare explicita
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(100);
            }

            PrintArray(v, "Elementele generate:");

            //Array.Sort(v);

            //Util.SelectionSort(v);

            Util.InsertionSort(v);
            PrintArray(v, "Elementele dupa sortare:");


        }

        private static void PrintArray(int[] v, string s)
        {
            Console.WriteLine(s);
            foreach (var item in v)
            {
                Console.WriteLine(item);
            }
        }
    }
}
