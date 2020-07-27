using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@">>(\w+)<<(\d+\.?\d+)!(\d+)");
            List<string> furnitures = new List<string>();
            double tottalSum = 0.00;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Purchase")
            {
                if (pattern.IsMatch(command))
                {
                    var result = pattern.Match(command);
                    furnitures.Add(result.Groups[1].Value);
                    tottalSum += (double.Parse(result.Groups[2].Value) * int.Parse(result.Groups[3].Value));
                }
                
            }

            Console.WriteLine("Bought furniture:");
            if (furnitures.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            }
            Console.WriteLine($"Total money spend: {tottalSum:f2}");
        }
    }
}
