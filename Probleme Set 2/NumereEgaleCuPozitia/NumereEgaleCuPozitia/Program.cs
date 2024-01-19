using System;

namespace NumereEgaleCuPozitia
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            Console.WriteLine("Introduceti elementele secventei:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == i)
                {
                    count++;
                }
            }

            Console.WriteLine($"Numarul de elemente egale cu pozitia lor este: {count}");
        }
    }
}
