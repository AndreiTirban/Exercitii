using System;

namespace LeapYearCounter
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti anul de start : ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti anul de sfarsit : ");
            int y2 = int.Parse(Console.ReadLine());

            int countLeapYears = CountLeapYears(y1, y2);

            Console.WriteLine($"Numarul de ani bisecti intre {y1} si {y2} este: {countLeapYears}");
        }

        static int CountLeapYears(int startYear, int endYear)
        {
            int count = 0;
            for (int year = startYear; year <= endYear; year++)
            {
                if (IsLeapYear(year))
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
