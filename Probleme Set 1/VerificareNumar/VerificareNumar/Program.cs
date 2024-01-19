using System;

namespace VerificareNumar
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti un numar: ");
            long numar = long.Parse(Console.ReadLine());

            if (EsteNumarFormatDoarCuDouaCifre(numar))
            {
                Console.WriteLine("Numarul este format doar cu 2 cifre care se pot repeta.");
            }
            else
            {
                Console.WriteLine("Numarul NU este format doar cu 2 cifre care se pot repeta.");
            }
        }

        static bool EsteNumarFormatDoarCuDouaCifre(long numar)
        {
            string numarString = numar.ToString();

            if (numarString.Length < 2)
            {
                return false;
            }

            char primaCifra = numarString[0];

            for (int i = 1; i < numarString.Length; i++)
            {
                if (numarString[i] != primaCifra)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
