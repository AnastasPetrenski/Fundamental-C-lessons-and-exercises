using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            List<int> subLength = new List<int>();
            int[] maxLength = new int[subLength.Count()];
            int maxSubsequence = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int subsequence = 0;
                for (int x = i; x < numbers.Length; x++)
                {
                    if (true)
                    {

                    }
                    subLength.Add(numbers[x]);
                    if (numbers[x + 1] < numbers[x])
                    {
                        while (true)
                        {
                            int lastElement = subLength.Last();
                            if (numbers[x + 1] < lastElement && subLength.Count > 1)
                            {
                                subLength.RemoveAt(subLength.Count - 1);
                                //numbers[x + 1]--;
                            }
                            else
                            {
                                subLength.Add(numbers[x + 1]);
                                break;
                            }
                            
                        }                        
                        
                    }
                    if (numbers[x + 1] == numbers.Length - 1)
                    {
                        break;
                    }
                }
                subsequence = subLength.Count();
                if (subsequence > maxSubsequence)
                {
                    maxSubsequence = subsequence;
                    maxLength = subLength.ToArray();
                }
            }
            
            Console.WriteLine(string.Join(" ", maxLength));

        }
    }
}
