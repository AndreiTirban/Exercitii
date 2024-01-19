using System;

namespace VerificaAnBisect
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti anul: ");
            int an = int.Parse(Console.ReadLine());

            if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            {
                Console.WriteLine($"{an} este an bisect.");
            }
            else
            {
                Console.WriteLine($"{an} nu este an bisect.");
            }
        }
    }
}
