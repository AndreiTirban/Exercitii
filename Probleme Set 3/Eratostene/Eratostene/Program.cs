using System;

namespace Eratostene
{
    class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        bool[] primes = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            if (primes[p] == true)
            {
                for (int i = p * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }

        for (int i = 2; i <= n; i++)
        {
            if (primes[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
}
