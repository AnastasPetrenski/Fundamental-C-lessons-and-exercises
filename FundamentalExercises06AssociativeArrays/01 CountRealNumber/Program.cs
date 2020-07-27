using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var item in numbers)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine(item);
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
