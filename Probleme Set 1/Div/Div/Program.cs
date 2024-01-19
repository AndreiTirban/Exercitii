using System;

namespace VerificaDivizibilitate
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti k: ");
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}.");
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}.");
            }
        }
    }
}
