using System;
using System.Text.RegularExpressions;

namespace _14_ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string expression = Console.ReadLine();
                int startIndex = expression.IndexOf('@');
                int endIndex = expression.IndexOf('|');
                int length = endIndex - startIndex;
                string name = expression.Substring(startIndex + 1, length - 1);

                int startIndexAge = expression.IndexOf('#');
                int endIndexAge = expression.IndexOf('*');
                int lengthAge = endIndexAge - startIndexAge;
                string age = expression.Substring(startIndexAge + 1, lengthAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
