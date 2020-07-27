using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> num2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> mixedList = new List<int>();
            List<int> boundery = new List<int>();
            if (num1.Count > num2.Count)
            {
                boundery.Add(num1[num1.Count - 1]);
                boundery.Add(num1[num1.Count - 2]);
                num1.RemoveRange(num1.Count - 2, 2);
            }
            else
            {
                boundery.Add(num2[0]);
                boundery.Add(num2[1]);
                num2.RemoveRange(0, 2);
            }
            num2.Reverse();
            boundery.Sort();

            for (int i = 0; i < num1.Count; i++)
            {
                mixedList.Add(num1[i]);
                mixedList.Add(num2[i]);
            }

            List<int> result = mixedList.FindAll(x => x > boundery[0] && x < boundery[1]);
            result.Sort();
            Console.WriteLine(string.Join(" ", result));





        }
    }
}
