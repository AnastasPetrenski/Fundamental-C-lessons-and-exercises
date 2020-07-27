using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> input = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!companyEmployees.ContainsKey(input[0]))
                {
                    companyEmployees.Add(input[0], new List<string>());
                    companyEmployees[input[0]].Add(input[1]);
                }
                else if (companyEmployees.ContainsKey(input[0]) && !companyEmployees[input[0]].Contains(input[1]))
                {
                    companyEmployees[input[0]].Add(input[1]);
                }
            }

            foreach (var item in companyEmployees.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
