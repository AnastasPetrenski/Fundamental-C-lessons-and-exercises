using System;
using System.Text.RegularExpressions;

namespace _06_SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"%(?<name>[A-Z][a-z]+)%.*?<(?<product>\w+)>.*?\|(?<quantity>\d+)\|.*?(?<price>\d+\.?\d+)\$");
            double totalSum = 0.00;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of shift")
            {
                var results = pattern.Matches(command);
                
                if (pattern.IsMatch(command))
                {
                    foreach (Match item in results)
                    {
                        var bill = (double.Parse(item.Groups["price"].Value) * int.Parse(item.Groups["quantity"].Value));
                        Console.WriteLine($"{item.Groups["name"]}: {item.Groups[2]} - {bill:f2}");
                        totalSum += bill;
                    }
                }
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
