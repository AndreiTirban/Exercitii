using System;

namespace EcuatieGrad1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceți coeficientul a: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduceți coeficientul b: ");
            float b = Convert.ToSingle(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia are infinitate de solutii.");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii.");
                }
            }
            else
            {

                float x = -b / a;

                Console.WriteLine("Solutia ecuatiei {0}*x + {1} = 0 este x = {2}", a, b, x);
            }

            Console.ReadLine();
        }
    }
}

