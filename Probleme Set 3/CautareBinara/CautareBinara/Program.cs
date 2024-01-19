using System;

namespace CautareBinara
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 8;

            int rezultat = CautareBinară(vector, k);

            Console.WriteLine($"Pozitia elementului {k} este: {rezultat}");
        }

        static int CautareBinară(int[] vector, int k)
        {
            int stanga = 0;
            int dreapta = vector.Length - 1;

            while (stanga <= dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

                if (vector[mijloc] == k)
                    return mijloc;
                else if (vector[mijloc] < k)
                    stanga = mijloc + 1;
                else
                    dreapta = mijloc - 1;
            }

            return -1;
        }
    }
}
