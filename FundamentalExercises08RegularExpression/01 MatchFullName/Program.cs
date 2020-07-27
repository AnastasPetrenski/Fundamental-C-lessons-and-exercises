using System;
using System.Text.RegularExpressions;

namespace _01_MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            string names = Console.ReadLine();
            MatchCollection matchedNames = regex.Matches(names);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
