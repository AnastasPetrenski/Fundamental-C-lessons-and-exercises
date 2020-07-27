using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex matchName = new Regex(@"[A-Za-z]");
            Regex matchDistance = new Regex(@"\d");
            List<string> racers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> infoRacers = new Dictionary<string, int>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of race")
            {
                var letters = matchName.Matches(command);
                StringBuilder name = new StringBuilder();
                foreach (Match item in letters)
                {
                    name.Append(item.Value);
                }

                var digits = matchDistance.Matches(command);
                int sumDigits = digits.Select(x => int.Parse(x.Value)).Sum();

                if (racers.Contains(name.ToString()))
                {
                    if (!infoRacers.ContainsKey(name.ToString()))
                    {
                        infoRacers.Add(name.ToString(), sumDigits);
                    }
                    else
                    {
                        infoRacers[name.ToString()] += sumDigits;
                    }
                }
            }

            int count = 1;
            foreach (var item in infoRacers.OrderByDescending(x => x.Value).Take(3))
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                count++;
            }
        }
    }
}
