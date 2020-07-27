using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();
            //numbers = numbers.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ", numbers.Take(3)));
        }
    }
}
