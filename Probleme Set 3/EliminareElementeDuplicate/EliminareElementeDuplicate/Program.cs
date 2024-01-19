using System;
namespace EliminareElementeDuplicate
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 1, 2, 3, 2, 4, 5, 6, 1, 7, 8, 7, 9 };

            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        for (int k = j; k < vector.Length - 1; k++)
                        {
                            vector[k] = vector[k + 1];
                        }
                        Array.Resize(ref vector, vector.Length - 1);
                        j--;
                    }
                }
            }

            Console.Write("Vectorul dupa eliminarea elementelor duplicate: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
