using System;

namespace SumaProdus
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;
            int produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
        }
    }
}
