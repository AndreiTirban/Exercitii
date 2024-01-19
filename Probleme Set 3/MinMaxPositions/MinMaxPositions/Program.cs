using System;

namespace GasesteMinMax
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 4, 7, 1, 9, 3, 8, 2, 6, 5 };

            int pozitieMin = 0;
            int pozitieMax = 0;

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < vector[pozitieMin])
                {
                    pozitieMin = i;
                }

                if (vector[i] > vector[pozitieMax])
                {
                    pozitieMax = i;
                }
            }

            Console.WriteLine($"Pozitia celui mai mic element: {pozitieMin}");
            Console.WriteLine($"Pozitia celui mai mare element: {pozitieMax}");
        }
    }
}
