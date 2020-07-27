using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string combination = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char input = char.Parse(Console.ReadLine());
                combination += input;
            }
            Console.WriteLine(combination);
        }
    }
}
