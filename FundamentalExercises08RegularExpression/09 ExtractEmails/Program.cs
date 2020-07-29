using System;
using System.Text.RegularExpressions;

namespace _09_ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex email = new Regex(@"[A-Za-z0-9]+[-_\.]?[A-Za-z0-9]+@[A-Za-z]+-?[A-Za-z]+\.[A-Za-z]+\.?[A-Za-z]+");
            Regex validator = new Regex(@" \b([a-z](?:_?[a-z0-9\-\.]+@[a-z\-]+\.[a-z]+([\.a-z]+)?))\b");
            string input = Console.ReadLine();
            var list = validator.Matches(input);
            foreach (Match item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
