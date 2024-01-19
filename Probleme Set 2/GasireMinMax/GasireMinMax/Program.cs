using System;

namespace GasireMinMax
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul de elemente din secventa: ");
            int n = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                int num = int.Parse(Console.ReadLine());

                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }

            Console.WriteLine($"Cea mai mica valoare din secventa: {min}");
            Console.WriteLine($"Cea mai mare valoare din secventa: {max}");
        }
    }
}
