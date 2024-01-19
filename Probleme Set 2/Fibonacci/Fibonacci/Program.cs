using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            int result = CalculateFibonacci(n);

            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {result}");
        }

        static int CalculateFibonacci(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
            {
                int a = 0;
                int b = 1;
                int result = 0;

                for (int i = 3; i <= n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }

                return result;
            }
        }
    }
}
