using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = { " ", "," };
            int[] arr1 = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isEqual = true;
            int index = 0;
            int sum = 0;
            while (isEqual)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        sum += arr1[i];
                    }
                    else
                    {
                        index = i;
                        isEqual = false;
                        Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                        return;
                    }
                }
                break;
            }
            //if (isEqual)
            //{
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //}
            //else
            //{
            //    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            //}
        }
    }
}
