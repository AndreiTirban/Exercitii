using System;

namespace MinMaxCount
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 5, 3, 8, 2, 7, 1, 4, 8, 6, 2 }; // Schimba valorile vectorului dupa nevoie

            int min = int.MaxValue;
            int max = int.MinValue;
            int minCount = 0;
            int maxCount = 0;

            foreach (var num in vector)
            {
                if (num < min)
                {
                    min = num;
                    minCount = 1;
                }
                else if (num == min)
                {
                    minCount++;
                }

                if (num > max)
                {
                    max = num;
                    maxCount = 1;
                }
                else if (num == max)
                {
                    maxCount++;
                }
            }

            Console.WriteLine($"Cea mai mica valoare: {min}, apar de {minCount} ori");
            Console.WriteLine($"Cea mai mare valoare: {max}, apar de {maxCount} ori");
        }
    }
}
