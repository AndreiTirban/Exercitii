using System;

namespace TestPrimalitate
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti un numar: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool estePrim = EstePrim(n);

            if (estePrim)
                Console.WriteLine($"{n} este un numar prim.");
            else
                Console.WriteLine($"{n} nu este un numar prim.");
        }

        static bool EstePrim(int numar)
        {
            if (numar <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numar); i++)
            {
                if (numar % i == 0)
                    return false;
            }

            return true;
        }
    }
}
