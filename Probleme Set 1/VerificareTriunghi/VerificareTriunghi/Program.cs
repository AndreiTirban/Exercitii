using System;

namespace VerificaTriunghi
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti lungimea laturii a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (EsteTriunghi(a, b, c))
            {
                Console.WriteLine("Cele trei numere pot fi lungimile laturilor unui triunghi.");
            }
            else
            {
                Console.WriteLine("Cele trei numere nu pot fi lungimile laturilor unui triunghi.");
            }
        }

        static bool EsteTriunghi(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
