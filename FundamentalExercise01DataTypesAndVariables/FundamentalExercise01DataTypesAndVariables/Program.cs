﻿using System;

namespace IntegerOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int result = 0;
            result = num1 + num2;
            result = result / num3;
            result *= num4;
            Console.WriteLine($"{result}");
        }
    }
}
