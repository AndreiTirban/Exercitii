using System;

namespace SumaInverselor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());

            double sumaInverselor = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                double numar = double.Parse(Console.ReadLine());
                sumaInverselor += 1 / numar;
            }

            Console.WriteLine($"Suma inverselor este: {sumaInverselor}");
        }
    }
}
