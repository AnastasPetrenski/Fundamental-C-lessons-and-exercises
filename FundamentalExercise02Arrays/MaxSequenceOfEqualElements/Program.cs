using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string output = string.Empty;
            int maxLength = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                string innerOutput = input[i] + " ";
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        innerOutput += input[j] + " ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (innerOutput.Length > maxLength)
                {
                    output = innerOutput;
                    maxLength = innerOutput.Length;
                }
            }
            string[] outputArr = output.Split();
            foreach (var item in outputArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
