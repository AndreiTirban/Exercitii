using System;

namespace GasestePozitia
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 3, 6, 1, 8, 4, 2, 9, 7, 5 };
            int k = 4;

            int rezultat = GasestePozitia(vector, k);

            Console.WriteLine(rezultat);
        }

        static int GasestePozitia(int[] vector, int k)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == k)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
