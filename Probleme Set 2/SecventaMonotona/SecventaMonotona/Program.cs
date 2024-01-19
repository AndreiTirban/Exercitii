using System;

namespace SecventaMonotona
{
    class Program
    {
        static void Main()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            bool isMonotonic = true;

            if (num1 > num2)
            {
                for (int i = 2; i < n; i++)
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    if (currentNum > num2)
                    {
                        isMonotonic = false;
                        break;
                    }
                    num2 = currentNum;
                }
            }
            else if (num1 < num2)
            {
                for (int i = 2; i < n; i++)
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    if (currentNum < num2)
                    {
                        isMonotonic = false;
                        break;
                    }
                    num2 = currentNum;
                }
            }
            else
            {
                isMonotonic = false;
            }

            if (isMonotonic)
            {
                Console.WriteLine("Secventa este monotona.");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona.");
            }
        }
    }
}
