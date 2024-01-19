using System;

namespace DivizorComunSiMultipluComun
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti primul numar: ");
            int numar1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int numar2 = int.Parse(Console.ReadLine());

            int cmmmc = CalculCMMMC(numar1, numar2);
            int cmmdc = CalculCMDC(numar1, numar2);

            Console.WriteLine($"Cel mai mare divizor comun: {cmmdc}");
            Console.WriteLine($"Cel mai mic multiplu comun: {cmmmc}");
        }

        static int CalculCMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int CalculCMMMC(int a, int b)
        {
            return a * b / CalculCMDC(a, b);
        }
    }
}
