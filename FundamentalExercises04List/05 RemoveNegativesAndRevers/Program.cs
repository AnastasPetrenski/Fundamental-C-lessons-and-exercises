﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_RemoveNegativesAndRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            numbers.RemoveAll(n => n < 0);
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else if (true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
