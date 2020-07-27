using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_GaussTrickCreatNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadAndCreatList();
            Console.WriteLine(String.Join(" ", SumPairs(numbers)));
        }

        static List<int> ReadAndCreatList()
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            return list;
        }

        static List<int> SumPairs(List<int> numbers)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                list.Add(numbers[i] + numbers[numbers.Count - 1 -i]);
            }

            if (numbers.Count % 2 != 0)
            {
                list.Add(numbers[numbers.Count / 2]);
            }

            return list;
        }
    }
}
