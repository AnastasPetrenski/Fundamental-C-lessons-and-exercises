using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ListManipulationAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
            List<int> numbers = new List<int>(input);
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> currentCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (currentCommand.Contains("Add"))
                {
                    numbers.Add(int.Parse(currentCommand[1]));
                }
                else if (currentCommand.Contains("Remove"))
                {
                    numbers.Remove(int.Parse(currentCommand[1]));
                }
                else if (currentCommand.Contains("RemoveAt"))
                {
                    if (int.Parse(currentCommand[1]) >= 0 && int.Parse(currentCommand[1]) <= numbers.Count - 1)
                    {
                        numbers.RemoveAt(int.Parse(currentCommand[1]));
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand.Contains("Insert"))
                {
                    if (int.Parse(currentCommand[2]) >= 0 && int.Parse(currentCommand[2]) <= numbers.Count - 1)
                    {
                        numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand.Contains("Contains"))
                {
                    if (numbers.Contains(int.Parse(currentCommand[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (currentCommand.Contains("PrintEven"))
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            Console.Write($"{item} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (currentCommand.Contains("PrintOdd"))
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 != 0)
                        {
                            Console.Write($"{item} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (currentCommand.Contains("GetSum"))
                {
                    Console.WriteLine(numbers.Sum()); 
                }
                else if (currentCommand.Contains("Filter"))
                {
                    if (currentCommand[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < int.Parse(currentCommand[2]))));
                    }
                    else if (currentCommand[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > int.Parse(currentCommand[2]))));
                    }
                    else if (currentCommand[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= int.Parse(currentCommand[2]))));
                    }
                    else if (currentCommand[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= int.Parse(currentCommand[2]))));
                    }
                }
            }   
            
            if (!input.SequenceEqual(numbers))
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
