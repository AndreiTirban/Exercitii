using System;

namespace NumerePare
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());

            int numerePare = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());

                if (EstePar(numar))
                {
                    numerePare++;
                }
            }

            Console.WriteLine($"Numere pare: {numerePare}");
        }

        static bool EstePar(int numar)
        {
            return numar % 2 == 0;
        }
    }
}
