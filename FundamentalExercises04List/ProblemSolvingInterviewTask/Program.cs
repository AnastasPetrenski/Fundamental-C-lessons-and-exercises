using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingInterviewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have two array with digits and a target. Find the closest sum of pair from the two arrays to the target.
            List<int> firstArray = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondArray = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int target = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            int secondDigit = 0;
            int sum = 0;
            int diff = 0;
            int minDiff = int.MaxValue;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < firstArray.Count; i++)
            {
                for (int j = 0; j < secondArray.Count; j++)
                {
                    sum = Math.Abs(firstArray[i] + secondArray[j]);
                    diff = Math.Abs(sum - target);
                    if (diff <= minDiff)
                    {
                        minDiff = diff;
                        firstDigit = firstArray[i];
                        secondDigit = secondArray[j];
                    }
                }
            }
            Console.WriteLine($"{firstDigit}, {secondDigit}");
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedTime);

            watch.Restart();
            GetTheClosestPair(firstArray, secondArray, target);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedTime);
        }

        static void GetTheClosestPair(List<int> firstArray, List<int> secondArray, int target)
        {
            firstArray.Sort();
            secondArray.Sort();
            int x = firstArray.Count - 1;
            int y = 0;
            int sum = 0;
            int minDiff = int.MaxValue;
            int firstDigit = 0;
            int secondDigit = 0;
            while (x > 0 && y < secondArray.Count)
            {
                sum = Math.Abs(firstArray[x] +secondArray[y]);
                int diff = Math.Abs(sum - target);

                if (diff < minDiff)
                {
                    minDiff = diff;
                    firstDigit = firstArray[x];
                    secondDigit = secondArray[y];
                }
                if (sum >= target)
                {
                    x--;
                }
                else
                {
                    y++;
                }
            }
            Console.WriteLine($"{firstDigit}, {secondDigit}");
        }
    }
}
