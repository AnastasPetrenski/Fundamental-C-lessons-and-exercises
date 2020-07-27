using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadAndCreatList();
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End")
            {
                List<string> currCommand = ConvertCommandToList(commands);
                if (currCommand.Contains("Add"))
                {
                    numbers.Add(int.Parse(currCommand[1]));
                }
                else if (currCommand.Contains("Insert"))
                {
                    if (int.Parse(currCommand[2]) >= 0 && int.Parse(currCommand[2]) < numbers.Count)
                    {
                        numbers.Insert(int.Parse(currCommand[2]), int.Parse(currCommand[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (currCommand.Contains("Remove"))
                {
                    if ((int.Parse(currCommand[1]) >= 0 && int.Parse(currCommand[1]) < numbers.Count))
                    {
                        numbers.RemoveAt(int.Parse(currCommand[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (currCommand.Contains("left"))
                {
                    for (int i = 0; i < int.Parse(currCommand[2]); i++)
                    {
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            int temp = numbers[0];
                            numbers.Add(temp);
                            numbers.RemoveAt(0);
                        }
                    }
                }
                else if (currCommand.Contains("right"))
                {
                    for (int i = 0; i < int.Parse(currCommand[2]); i++)
                    {
                        int temp = numbers[numbers.Count - 1];
                        for (int j = numbers.Count - 1; j > 0; j--)
                        {
                            numbers[j] = numbers[j - 1];
                        }
                        numbers[0] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> ReadAndCreatList()
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            return list;
        }

        static List<string> ConvertCommandToList(string commands)
        {
            List<string> currCommand = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            return currCommand;
        }
    }
}
