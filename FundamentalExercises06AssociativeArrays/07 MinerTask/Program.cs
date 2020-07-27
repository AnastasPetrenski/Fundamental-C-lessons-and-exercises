using System;
using System.Collections.Generic;

namespace _07_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> goods = new Dictionary<string, long>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "stop")
            {
                string resource = command;
                long quantity = long.Parse(Console.ReadLine());
                if (!goods.ContainsKey(resource))
                {
                    goods.Add(resource, quantity);
                }
                else
                {
                    goods[resource] += quantity;
                }
            }

            foreach (var item in goods)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
