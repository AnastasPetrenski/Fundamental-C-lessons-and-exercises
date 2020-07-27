using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyNumber = int.Parse(Console.ReadLine());
            int inputNumberLetters = int.Parse(Console.ReadLine());
            string decryptedWord = string.Empty;
            for (int i = 0; i < inputNumberLetters; i++)
            {
                char singleLetter = char.Parse(Console.ReadLine());
                int newLetter = (int)singleLetter + keyNumber;
                singleLetter = Convert.ToChar(newLetter);
                decryptedWord += singleLetter;
            }
            Console.WriteLine(decryptedWord);
            for (int j = 0; j < inputNumberLetters; j++)
            {
                decryptedWord += ((char)(char.Parse(Console.ReadLine()) + keyNumber)).ToString();
            }
        }
    }
}
