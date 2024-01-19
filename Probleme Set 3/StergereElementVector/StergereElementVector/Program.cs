using System;

namespace StergereElementVector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Citire vector
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            // Citire pozitie k
            Console.Write("Introduceti pozitia k: ");
            int k = int.Parse(Console.ReadLine());

            // Stergere element de pe pozitia k
            for (int i = k; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            // Redimensionare vector
            Array.Resize(ref vector, n - 1);

            // Afisare rezultat
            Console.WriteLine("Vectorul dupa stergerea elementului:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
