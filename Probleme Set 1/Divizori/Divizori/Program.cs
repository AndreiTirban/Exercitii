using System;

namespace Divizori
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti un numar: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Divizorii numarului {0} sunt: ", n);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
