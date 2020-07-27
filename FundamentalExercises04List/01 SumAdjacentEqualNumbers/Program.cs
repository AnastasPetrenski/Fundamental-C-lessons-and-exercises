using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            SumAdjacentEqualElements(numbers);
        }

        static void SumAdjacentEqualElements(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((i + 1) == numbers.Count)
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
        }
    }
}
