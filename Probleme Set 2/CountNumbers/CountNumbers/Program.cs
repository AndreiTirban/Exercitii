using System;

namespace CountNumbers
{
    class Program
    {
        static void Main()
        {
            int n;
            int negativeCount = 0, zeroCount = 0, positiveCount = 0;

            Console.Write("Introduceti numarul de elemente: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                    negativeCount++;
                else if (num == 0)
                    zeroCount++;
                else
                    positiveCount++;
            }

            Console.WriteLine($"Numere negative: {negativeCount}");
            Console.WriteLine($"Numere zero: {zeroCount}");
            Console.WriteLine($"Numere pozitive: {positiveCount}");
        }
    }
}
