using System;

namespace RotireVector
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 1, 2, 3, 4, 5 };
            int k = 2;
            RotireStanga(vector, k);

            Console.Write("Vectorul rotit la stanga cu {0} pozitii: ", k);
            AfisareVector(vector);
        }

        static void RotireStanga(int[] vector, int k)
        {
            int n = vector.Length;
            k %= n;

            ReverseSubvector(vector, 0, k - 1);
            ReverseSubvector(vector, k, n - 1);
            ReverseSubvector(vector, 0, n - 1);
        }

        static void ReverseSubvector(int[] vector, int start, int end)
        {
            while (start < end)
            {
                int temp = vector[start];
                vector[start] = vector[end];
                vector[end] = temp;
                start++;
                end--;
            }
        }

        static void AfisareVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
