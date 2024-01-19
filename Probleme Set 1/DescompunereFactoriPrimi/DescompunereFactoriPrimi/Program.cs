using System;

namespace DescompunereFactoriPrimi
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Descompunerea in factori primi a lui {0} este: ", n);

            for (int i = 2; i <= n; i++)
            {
                int count = 0;
                while (n % i == 0)
                {
                    count++;
                    n /= i;
                }

                if (count > 0)
                {
                    Console.Write("{0}^{1} ", i, count);
                    if (n > 1)
                    {
                        Console.Write("x ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
