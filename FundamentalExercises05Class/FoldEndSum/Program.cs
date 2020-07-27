using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldEndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> first = new List<int>();
            List<int> second = new List<int>();
            int n = numbers.Count();
            for (int i = 0; i < n/4; i++)
            {
                first.Add(numbers[0]);
                second.Add(numbers[numbers.Count - 1]);
                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count - 1);
            }
            first.Reverse();
            first.AddRange(second);

            List<int> result = new List<int>();
            for (int i = 0; i < first.Count; i++)
            {
                result.Add(first[i] + numbers[i]);
            }
            
            for (int i = 0; i < first.Count; i++)
            {
                var sum = first.Select((x, index) => x + numbers[i]).ToList();
                Console.Write(sum[i] + " ");
            }
            //Console.WriteLine();
            //Console.WriteLine(string.Join(" ", result));

        }
    }
}
