using System;

namespace SumaVector
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul de elemente ale vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += vector[i];
            }

            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
        }
    }
}
