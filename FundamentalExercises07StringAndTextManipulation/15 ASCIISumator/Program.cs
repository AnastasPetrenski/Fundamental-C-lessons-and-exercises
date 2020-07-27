using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_ASCIISumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            var expression = Console.ReadLine().Trim().ToList();
            int totalSum = 0;
            for (int i = 0; i < expression.Count; i++)
            {
               
                int min = Math.Min(start, end);
                int max = Math.Max(start, end);
                int currentChar = expression[i];
                if (min < currentChar && currentChar < max)
                {
                    totalSum += currentChar;
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
