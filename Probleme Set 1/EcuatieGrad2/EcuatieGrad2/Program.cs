using System;

namespace RezolvareEcuatieGradul2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti coeficientul a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti coeficientul b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti coeficientul c:");
            double c = Convert.ToDouble(Console.ReadLine());

            RezolvaEcuatieGrad2(a, b, c);

            Console.ReadLine();
        }

        static void RezolvaEcuatieGrad2(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Solutiile sunt x1 = {x1} si x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);

                Console.WriteLine($"Solutia unica este x = {x}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(Math.Abs(delta)) / (2 * a);

                Console.WriteLine($"Solutiile complexe sunt: ");
                Console.WriteLine($"x1 = {realPart} + {imaginaryPart}i");
                Console.WriteLine($"x2 = {realPart} - {imaginaryPart}i");
            }
        }
    }
}
