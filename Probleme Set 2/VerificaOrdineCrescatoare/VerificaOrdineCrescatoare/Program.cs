using System;

namespace VerificaOrdineCrescatoare
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introdu numarul de elemente: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool isCrescatoare = VerificaOrdineCrescatoare(n);

            if (isCrescatoare)
            {
                Console.WriteLine("Numerele sunt in ordine crescatoare.");
            }
            else
            {
                Console.WriteLine("Numerele nu sunt in ordine crescatoare.");
            }
        }

        static bool VerificaOrdineCrescatoare(int n)
        {
            int numarAnterior = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu numarul {i + 1}: ");
                int numarCurent = Convert.ToInt32(Console.ReadLine());

                if (numarCurent <= numarAnterior)
                {
                    return false;
                }

                numarAnterior = numarCurent;
            }

            return true;
        }
    }
}
