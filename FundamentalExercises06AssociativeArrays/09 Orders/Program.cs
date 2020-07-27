using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<decimal, int>> orders = new Dictionary<string, Dictionary<decimal, int>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "buy")
            {
                List<string> input = command.Split().ToList();
                if (!orders.ContainsKey(input[0]))
                {
                    orders.Add(input[0], new Dictionary<decimal, int>());
                    orders[input[0]].Add(decimal.Parse(input[1]), int.Parse(input[2]));
                }
                else
                {
                    decimal g = orders[input[0]].GetValueOrDefault(decimal.Parse(input[1]));
                    var c = orders[input[0]].FirstOrDefault();
                    int m = int.Parse(input[2]);
                    int b = c.Value + m;
                    orders[input[0]].Add(decimal.Parse(input[1]), b);
                    orders[input[0]].Remove(c.Key);
                }
            }

            foreach (var item in orders)
            {
                var result = item.Value.Select(x => x.Value * x.Key).ToList();
                //var components = orders[item.ToString()].FirstOrDefault();
                //decimal result = components.Key * components.Value;
                decimal x = result[0];
                Console.WriteLine($"{item.Key} -> {x:f2}");
            }
        }
    }
}
