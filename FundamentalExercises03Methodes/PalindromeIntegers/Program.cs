using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                int number = int.Parse(command);
                PalindromeComparison(number);
            }
        }

        static void PalindromeComparison(int number)
        {
            char[] arr = number.ToString().ToCharArray();
            bool isPalindrom = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != CreateArrayInReverseOrder(arr)[i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            
            if (isPalindrom)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static char[] CreateArrayInReverseOrder(char[] arr)
        {

            string forPalindrom = string.Empty;
            foreach (char item in arr)
            {
                forPalindrom += item;
            }
            char[] palindrom = forPalindrom.ToCharArray();
            Array.Reverse(palindrom);
            return palindrom;
        }
    }
}