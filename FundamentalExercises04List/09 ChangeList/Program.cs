using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadAndCreatList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                ListManipulater(numbers, command);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> ReadAndCreatList()
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            return list;
        }

        static List<int> ListManipulater(List<int> numbers, string command)
        {
            List<string> commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            if (commands.Contains("Delete"))
            {
                numbers.RemoveAll(x => x == int.Parse(commands[1]));
            }
            else if (commands.Contains("Insert"))
            {
                numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
            }
            return numbers;
        }
    }
}
