using System;
using System.Linq;

namespace PalindromeIntegers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrom(input).ToString().ToLower()); 
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrom(string text)
        {
            bool isPalindrom = true;
            var reversed = text.Reverse().ToArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (reversed[i] != text[i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }
    }
}
