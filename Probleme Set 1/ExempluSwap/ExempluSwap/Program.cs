﻿using System;

namespace SwapProgram
{
    class Program
    {
        static void Main()
        {
            int a, b;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
