using System;
using System.Linq;
using System.Collections.Generic;

namespace _06_ListManipulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> currentCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (currentCommand.Contains("Add"))
                {
                    numbers.Add(Convert.ToInt32(currentCommand[1]));
                }
                else if (currentCommand.Contains("Remove"))
                {
                    numbers.Remove(Convert.ToInt32(currentCommand[1]));
                }
                else if (currentCommand.Contains("RemoveAt"))
                {
                    if (Convert.ToInt32(currentCommand[1]) >= 0 && Convert.ToInt32(currentCommand[1]) <= numbers.Count - 1)
                    {
                        numbers.RemoveAt(Convert.ToInt32(currentCommand[1]));
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand.Contains("Insert"))
                {
                    if (Convert.ToInt32(currentCommand[2]) >= 0 && Convert.ToInt32(currentCommand[2]) <= numbers.Count - 1)
                    {
                        numbers.Insert(Convert.ToInt32(currentCommand[2]), Convert.ToInt32(currentCommand[1]));
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
