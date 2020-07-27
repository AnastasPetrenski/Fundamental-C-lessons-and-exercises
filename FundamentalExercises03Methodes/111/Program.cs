using System;
namespace Demo
{
    class MyArray
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                char[] inputArr = input.ToCharArray();
                Array.Reverse(inputArr);
                string palindrome = new string(inputArr);
                StringCompare(input, palindrome);
                StringEqual(input, palindrome);
                CompareMethod(input, palindrome);
            }
        }

        private static void StringCompare(string input, string palindrome)
        {
            if (String.Compare(input, palindrome) == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static void StringEqual(string input, string palindrome)
        {
            if (String.Equals(input, palindrome))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static void CompareMethod(string input, string palindrome)
        {
            if (input.CompareTo(palindrome) == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}