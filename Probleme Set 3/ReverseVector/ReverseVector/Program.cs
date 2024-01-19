using System;

namespace ReverseVector
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceti elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n / 2; i++)
            {
                int temp = vector[i];
                vector[i] = vector[n - 1 - i];
                vector[n - 1 - i] = temp;
            }

            Console.WriteLine("Vectorul inversat:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
