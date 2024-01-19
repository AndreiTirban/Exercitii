using System;

namespace SortareNumere
{
    class Program
    {
        static void Main()
        {
            int a, b, c;

            Console.Write("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}
