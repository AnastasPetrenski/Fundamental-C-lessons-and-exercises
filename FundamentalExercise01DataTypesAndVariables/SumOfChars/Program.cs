using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < letters; i++)
            {
                char singleLetter = char.Parse(Console.ReadLine());
                sum += (int)singleLetter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
