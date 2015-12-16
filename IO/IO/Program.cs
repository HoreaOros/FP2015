using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            string[] tokens;
            char[] separatori = { ' ', '\t', ';', ',' };

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    tokens = line.Split(separatori, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine(line);

                    foreach (var item in tokens)
                    {
                        suma = suma + int.Parse(item);
                    }
                }
            }
            
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                sw.WriteLine("Suma numerelor din fisier este: {0}", suma);
            }
        }
     }
 }
