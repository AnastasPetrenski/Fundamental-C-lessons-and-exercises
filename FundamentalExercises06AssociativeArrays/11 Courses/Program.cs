using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {

                List<string> input = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!courses.ContainsKey(input[0]))
                {
                    courses.Add(input[0], new List<string>());
                    courses[input[0]].Add(input[1]);
                }
                else
                {
                    courses[input[0]].Add(input[1]);
                }
            }
            
            foreach (var item in courses.OrderByDescending(x => x.Value.Count))//.ThenBy(x => x.Value) do not order names in the list
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var name in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
