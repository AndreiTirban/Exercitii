using System;

namespace PalindromCheck
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());

            if (EstePalindrom(numar))
                Console.WriteLine("Numarul este palindrom.");
            else
                Console.WriteLine("Numarul nu este palindrom.");
        }

        static bool EstePalindrom(int numar)
        {
            int original = numar;
            int invers = 0;

            while (numar > 0)
            {
                int ultimaCifra = numar % 10;
                invers = (invers * 10) + ultimaCifra;
                numar /= 10;
            }

            return original == invers;
        }
    }
}
