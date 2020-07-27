using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputStringLine = input.ToCharArray();
            CountVowelsContent(input, inputStringLine);
        }

        public static void CountVowelsContent(string input, char[] inputStringLine)
        {
            char[] vowelsArray = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
            int vowelsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = inputStringLine[i];
                if (vowelsArray.Contains(currentLetter))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }

    }
}


