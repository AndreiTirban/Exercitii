using System;

namespace ConversieBaza
{
    class Program
    {
        static void Main()
        {
            int n, b;

            Console.Write("Introduceti numarul in baza 10: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti baza de conversie (1 < b < 17): ");
            b = int.Parse(Console.ReadLine());

            if (b > 1 && b < 17)
            {
                string rezultat = ConversieBaza(n, b);
                Console.WriteLine($"Rezultatul conversiei: {rezultat}");
            }
            else
            {
                Console.WriteLine("Baza introdusa nu este valida.");
            }
        }

        static string ConversieBaza(int numar, int baza)
        {
            string rezultat = "";
            while (numar > 0)
            {
                int rest = numar % baza;
                char cifra = (char)(rest < 10 ? '0' + rest : 'A' + rest - 10);
                rezultat = cifra + rezultat;
                numar /= baza;
            }
            return rezultat == "" ? "0" : rezultat;
        }
    }
}
