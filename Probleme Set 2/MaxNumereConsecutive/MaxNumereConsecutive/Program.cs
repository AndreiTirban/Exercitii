using System;

namespace MaxNumereConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti secventa de numere separate prin spatiu: ");
            string input = Console.ReadLine();

            int maxConsecutive = GetMaxConsecutive(input);

            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este: {maxConsecutive}");
        }

        static int GetMaxConsecutive(string input)
        {
            int maxConsecutive = 1;
            int currentConsecutive = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == '\t')
                    continue;

                if (input[i] == input[i - 1])
                {
                    currentConsecutive++;
                    if (currentConsecutive > maxConsecutive)
                        maxConsecutive = currentConsecutive;
                }
                else
                {
                    currentConsecutive = 1;
                }
            }

            return maxConsecutive;
        }
    }
}
