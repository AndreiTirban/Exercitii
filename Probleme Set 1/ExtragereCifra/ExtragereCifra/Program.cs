using System;

namespace ExtrageCifra
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul: ");
            long numar = long.Parse(Console.ReadLine());

            Console.Write("Introduceti pozitia cifrei de la sfarsit (k): ");
            long k = long.Parse(Console.ReadLine());

            long cifra = ExtrageCifra(numar, k);

            Console.WriteLine($"Cifra de pe pozitia {k} de la sfarsitul numarului {numar} este: {cifra}");
        }

        static long ExtrageCifra(long numar, long k)
        {
            long contor = 0;

            while (numar > 0)
            {
                contor++;

                if (contor == k)
                {
                    return numar % 10;
                }

                numar /= 10;
            }

            return -1;
        }
    }
}
