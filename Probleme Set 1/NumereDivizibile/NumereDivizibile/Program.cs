using System;

namespace Divizibile
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui b: ");
            int b = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Numere divizibile cu {n} in intervalul [{a}, {b}]: {count}");
        }
    }
}
