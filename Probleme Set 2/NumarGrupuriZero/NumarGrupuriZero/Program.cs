using System;

namespace NumarGrupuriZero
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            int count = 0;
            int consecutiveZeros = 0;
            bool inZeroGroup = false;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    if (!inZeroGroup)
                    {
                        inZeroGroup = true;
                        count++;
                    }
                    consecutiveZeros++;
                }
                else
                {
                    inZeroGroup = false;
                }
            }

            Console.WriteLine(count);
        }
    }
}
