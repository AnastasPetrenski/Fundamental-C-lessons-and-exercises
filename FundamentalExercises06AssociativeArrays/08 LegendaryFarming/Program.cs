using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> legendaryItems = new Dictionary<string, string>();
            legendaryItems.Add("shards", "Shadowmourne");
            legendaryItems.Add("fragments", "Valanyr");
            legendaryItems.Add("motes", "Dragonwrath");
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0); 
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 != 0 && keyMaterials.ContainsKey(input[i].ToLower()))
                    {
                        keyMaterials[input[i].ToLower()] += int.Parse(input[i - 1]);
                        if (keyMaterials[input[i].ToLower()] >= 250)
                        {
                            keyMaterials[input[i].ToLower()] -= 250;
                            Console.WriteLine($"{legendaryItems[input[i].ToLower()]} obtained!");
                            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            foreach (var item in junk)
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;
                        }
                    }
                    else if (i % 2 != 0 && !keyMaterials.ContainsKey(input[i].ToLower()))
                    {
                        if (!junk.ContainsKey(input[i].ToLower()))
                        {
                            junk.Add(input[i].ToLower(), 0);
                            junk[input[i].ToLower()] += int.Parse(input[i - 1]);

                        }
                        else
                        {
                            junk[input[i].ToLower()] += int.Parse(input[i - 1]);
                        }
                    }
                }
                
            }
        }
    }
}
