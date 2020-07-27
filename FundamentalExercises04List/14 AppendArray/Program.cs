using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_AppendArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = SeparatorBySingleLineAndRevers();
            string reversedInput = CovertListToString(input);
            List<string> numbers = SeparatorBySpace(reversedInput);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<string> SeparatorBySpace(string reversedInput)
        {
            List<string> numbers = reversedInput.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            return numbers;
        }

        static string CovertListToString(List<string> input)
        {
            string reversedInput = string.Empty;
            foreach (var item in input)
            {
                reversedInput += item + " ";
            }
            return reversedInput;
        }

        static List<string> SeparatorBySingleLineAndRevers()
        {
            List<string> input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Reverse();
            return input;
        }
    }
}
