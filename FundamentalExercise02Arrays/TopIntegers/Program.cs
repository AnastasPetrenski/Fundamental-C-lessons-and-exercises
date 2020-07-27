using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).
                ToArray();
            
            for (long i = 0; i < arr.Length; i++)
            {
                bool isTop = true;
                for (long x = i+1; x < arr.Length; x++)
                {
                    if (arr[i] > arr[x])
                    {
                        continue;
                    }
                    else
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
