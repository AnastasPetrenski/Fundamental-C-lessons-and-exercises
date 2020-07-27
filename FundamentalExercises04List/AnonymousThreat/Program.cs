using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {       
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "3:1")
            {
                List<string> commands = commandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                int startIndex = int.Parse(commands[1]);
                int endPartition = int.Parse(commands[2]);

                if (commands.Contains("merge"))
                {
                    MergeStringElements(input, startIndex, endPartition);
                }
                else if (commands.Contains("divide"))
                {
                    DivideStringElementToPartitions(input, startIndex, endPartition);
                }
            }

            Console.WriteLine(string.Join(" ", input));

            static void DivideStringElementToPartitions(List<string> input, int index, int endPartition)
            {
                List<string> divideIndex = new List<string>();
                string word = input[index];
                int stringLengthToAdd = word.Length / endPartition;

                int startIndex = 0;
                for (int i = 0; i < endPartition; i++)
                {
                    if (i == endPartition - 1)
                    {
                        divideIndex.Add(word.Substring(startIndex, word.Length - startIndex));
                    }
                    else
                    {
                        divideIndex.Add(word.Substring(startIndex, stringLengthToAdd));
                        startIndex += stringLengthToAdd;
                    }
                }

                input.RemoveAt(index);
                input.InsertRange(index, divideIndex);
            }

            static void MergeStringElements(List<string> input, int startIndex, int endPartition)
            {
                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endPartition > input.Count - 1)
                {
                    endPartition = input.Count - 1;
                }

                for (int i = startIndex; i < endPartition; i++)
                {
                    input[startIndex] = input[startIndex] + input[startIndex + 1];
                    input.RemoveAt(startIndex + 1);
                }
            }
        }
    }
}
