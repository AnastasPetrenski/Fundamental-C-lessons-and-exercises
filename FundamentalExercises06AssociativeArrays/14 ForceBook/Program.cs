using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBookData = new Dictionary<string, List<string>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                List<string> input = command.Split().ToList();
                if (input.Contains("|"))
                {
                    List<string> addInput = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (!forceBookData.ContainsKey(addInput[0]) && !forceBookData.Any(x => x.Value.Contains(addInput[1])))
                    {
                        forceBookData.Add(addInput[0], new List<string>());
                        forceBookData[addInput[0]].Add(addInput[1]);
                    }
                    else if (forceBookData.ContainsKey(addInput[0]) && !forceBookData[addInput[0]].Contains(addInput[1])
                        && !forceBookData.Values.Any(x => x.Contains(addInput[1])))
                    {
                        forceBookData[addInput[0]].Add(addInput[1]);
                    }
                }
                else if (input.Contains("->"))
                {
                    List<string> dellInput = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (forceBookData.Any(x => x.Value.Contains(dellInput[0])))
                    {
                        string key = string.Empty;
                        foreach (var item in forceBookData)
                        {
                            if (item.Value.Contains(dellInput[0]))
                            {
                                item.Value.IndexOf(dellInput[0]);
                                item.Value.Remove(dellInput[0]);
                            }
                        }
                        if (forceBookData.ContainsKey(dellInput[1]))
                        {
                            forceBookData[dellInput[1]].Add(dellInput[0]);
                        }
                        else if (!forceBookData.ContainsKey(dellInput[1]))
                        {
                            forceBookData.Add(dellInput[1], new List<string>());
                            forceBookData[dellInput[1]].Add(dellInput[0]);
                        }
                        
                        Console.WriteLine($"{dellInput[0]} joins the {dellInput[1]} side!");
                    }
                    else if (!forceBookData.Any(x => x.Value.Contains(dellInput[0])))
                    {
                        if (forceBookData.ContainsKey(dellInput[1]))
                        {
                            forceBookData[dellInput[1]].Add(dellInput[0]);
                        }
                        else if (!forceBookData.ContainsKey(dellInput[1]))
                        {
                            forceBookData.Add(dellInput[1], new List<string>());
                            forceBookData[dellInput[1]].Add(dellInput[0]);
                        }
                        Console.WriteLine($"{dellInput[0]} joins the {dellInput[1]} side!");
                    }
                }
            }

            foreach (var item in forceBookData.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    foreach (var name in item.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {name}");
                    }
                }
                
            }
        }
    }
}
