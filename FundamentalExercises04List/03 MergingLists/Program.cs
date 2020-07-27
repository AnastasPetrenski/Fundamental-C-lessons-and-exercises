using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> num2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int maxLength = Math.Max(num1.Count, num2.Count);
            List<int> mergedList = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                if (i < num1.Count)
                {
                    mergedList.Add(num1[i]);
                }
                if (i < num2.Count)
                {
                    mergedList.Add(num2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
