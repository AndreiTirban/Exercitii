using System;

namespace DivizorComun
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { /* Introduceți aici elementele vectorului de numere naturale */ };

            int result = DivizorComun(numbers);
            Console.WriteLine("Cel mai mare divizor comun al elementelor vectorului este: " + result);
        }

        static int DivizorComun(int[] numbers)
        {
            int gcd = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                gcd = DivizorComun(gcd, numbers[i]);
            }

            return gcd;
        }

        static int DivizorComun(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
