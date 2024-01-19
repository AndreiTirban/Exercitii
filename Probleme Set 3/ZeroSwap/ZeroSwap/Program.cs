using System;

namespace ZeroSwap
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 1, 0, 5, 0, 3, 0, 7, 0, 9 };

            int left = 0;
            int right = vector.Length - 1;

            while (left < right)
            {
                while (left < right && vector[left] != 0)
                    left++;

                while (left < right && vector[right] == 0)
                    right--;

                if (left < right)
                {
                    int temp = vector[left];
                    vector[left] = vector[right];
                    vector[right] = temp;
                }
            }

            Console.WriteLine("Vectorul rezultat:");
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
        }
    }
}
