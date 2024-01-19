using System;

namespace GasireNumarInSecventa
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introdu lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());
                int rezultat = GasestePozitie(numar, i);
                Console.WriteLine("Pozitia numarului {0} in secventa este: {1}", numar, rezultat);
            }
        }

        static int GasestePozitie(int a, int pozitieCurenta)
        {
            Console.Write("Introduceti numarul cautat: ");
            int numarCautat = int.Parse(Console.ReadLine());

            if (numarCautat == a)
            {
                return pozitieCurenta;
            }
            else
            {
                return GasestePozitie(a, pozitieCurenta + 1);
            }
        }
    }
}
