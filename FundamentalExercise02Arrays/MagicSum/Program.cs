using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                for (int x = i+1; x < input.Length; x++)
                {
                    if ((input[i] + input[x]) == magicSum)
                    {
                        Console.WriteLine($"{input[i]} {input[x]}");
                    }
                    if (i + 1 == input.Length - 1)
                    {
                        break;
                    }
                }
            }
        }
    }
}
