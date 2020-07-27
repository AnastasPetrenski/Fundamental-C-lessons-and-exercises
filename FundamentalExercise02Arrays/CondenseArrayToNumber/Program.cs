using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = { " ", "," };
            int[] arr1 = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = new int[arr1.Length-1];
            int firstLength = arr1.Length - 1;
            if (arr2.Length > 0)
            {
                for (int x = 0; x < arr2.Length; x++)
                {
                    for (int i = 0; i < arr1.Length - 1; i++)
                    {
                        arr2[i] = arr1[i] + arr1[i + 1];
                    }
                    arr1 = arr2;
                }
                Console.WriteLine(arr2[0]);
            }
            else
            {
                Console.WriteLine(arr1[0]);
            }
            
            
        }
    }
}
