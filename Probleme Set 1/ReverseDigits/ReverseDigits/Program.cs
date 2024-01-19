using System;

namespace ReverseDigits
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti un numar: ");
            long n = long.Parse(Console.ReadLine());

            while (n > 0)
            {
                long digit = n % 10;
                Console.Write(digit);
                n = n / 10;
            }

            Console.WriteLine();
        }
    }
}
