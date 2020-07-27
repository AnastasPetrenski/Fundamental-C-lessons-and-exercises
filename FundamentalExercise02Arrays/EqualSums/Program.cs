using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            //int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 && arr.Length == 1)
                {
                    Console.WriteLine(i);
                    return;
                }
                else if (i == 0)
                {
                    sumLeft = 0;
                    sumRight = 0;
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        sumRight += arr[j];
                    }
                    
                    //index = i;
                }
                else if (i == arr.Length -1)
                {
                    sumRight = 0;
                    sumLeft = 0;
                    for (int x = arr.Length-2; x >= 0; x--)
                    {
                        sumLeft += arr[x];
                    }
                }
                else
                {
                    sumLeft = 0;
                    sumRight = 0;
                    for (int z = i-1; z >= 0; z--)
                    {
                        sumLeft += arr[z];
                    }
                    for (int k = i+1; k < arr.Length; k++)
                    {
                        sumRight += arr[k];
                    }
                    //index = i;
                    
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine($"{i}");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
