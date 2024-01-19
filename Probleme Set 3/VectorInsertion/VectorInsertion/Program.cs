using System;

namespace VectorInsertion
{
    class Program
    {
        static void Main()
        {
            // Citirea vectorului, valorii și poziției
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti valoarea de inserat: ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Introduceti pozitia de inserat: ");
            int k = int.Parse(Console.ReadLine());

            // Inserarea valorii la pozitia specificata
            int[] newVector = new int[n + 1];
            for (int i = 0; i < k; i++)
            {
                newVector[i] = vector[i];
            }

            newVector[k] = e;

            for (int i = k + 1; i < n + 1; i++)
            {
                newVector[i] = vector[i - 1];
            }

            // Afisarea vectorului rezultat
            Console.WriteLine("Vectorul rezultat este:");
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine(newVector[i]);
            }
        }
    }
}
