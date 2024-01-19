using System;

namespace RotireVector
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 1, 2, 3, 4, 5 };

            RotireStanga(vector);

            Console.WriteLine("Vectorul rotit spre stanga:");
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
        }

        static void RotireStanga(int[] vector)
        {
            int n = vector.Length;
            int temp = vector[0];

            for (int i = 0; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            vector[n - 1] = temp;
        }
    }
}
