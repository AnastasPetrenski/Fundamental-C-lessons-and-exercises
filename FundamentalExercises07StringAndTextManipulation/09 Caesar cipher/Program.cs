using System;
using System.Text;

namespace _09_Caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encryptedInput = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var newChar = input[i] + 3;
                encryptedInput.Append((char)newChar);
            }

            Console.WriteLine(encryptedInput);
        }
    }
}
