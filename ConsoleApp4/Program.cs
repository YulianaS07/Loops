using System;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {

            string wejscie = Console.ReadLine();
            short[] dane = Array.ConvertAll<string, short>(wejscie.Split(" "), short.Parse);

            short a = dane[0];
            short b = dane[1];
            
            if (a==b)
            {
                Console.WriteLine("empty");
                return;
            }

            string wynik = "";
            for (short i = (short)(a + 1); i < b; i++)
            {
                wynik += i + ", ";
            }

            wynik = wynik.TrimEnd(',', ' ');

            if (wynik == "")
            {
                Console.WriteLine("empty");
            }
            else if (wynik.Split(", ").Length <= 10)
            {
                Console.WriteLine(wynik);
            }
            else
            {
                string[] wynik1 = wynik.Split(", ");
                Console.WriteLine($"{wynik1[0]}, {wynik1[1]}, {wynik1[2]}, ..., {wynik1[wynik1.Length - 2]}, {wynik1[wynik1.Length - 1]}");
            }


        }
    }
}