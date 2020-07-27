using System;
using System.Text.RegularExpressions;

namespace _03_MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b(\d{2})([-\.\/])([A-Z][a-z]{2})\2(\d{4})\b");
            var datesList = Console.ReadLine();
            var dates = pattern.Matches(datesList);
            foreach (Match date in dates)
            {
                var day = date.Groups[1].Value;
                var month = date.Groups[3].Value;
                var year = date.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
