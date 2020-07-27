using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptSortAndPrintArrayOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStrings = int.Parse(Console.ReadLine());
            string vowels = "aAeEiIoOuU";
            char[] vowelsArr = vowels.ToCharArray();
            int[] numbers = new int[numberStrings];
            for (int i = 0; i < numberStrings; i++)
            {
                string word = Console.ReadLine();
                char[] letters = word.ToCharArray();

                int sum = 0;
                for (int x = 0; x < letters.Length; x++)
                {
                    char letter = letters[x];
                    if (vowelsArr.Contains(letter))
                    {
                        sum += letters[x] * word.Length;
                    }
                    else
                    {
                        sum += letters[x] / word.Length;
                    }
                }
                numbers[i] = sum;
            }
            Array.Sort(numbers);
            Console.WriteLine(string.Join("\n", numbers));

        }
    }
}
