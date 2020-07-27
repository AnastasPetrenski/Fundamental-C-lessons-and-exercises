using System;

namespace _03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string match = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            var index = 0;
            while (index != -1)
            {
                index = word.IndexOf(match);
                if (index > -1)
                {
                    word = word.Remove(index, match.Length);
                }
            }
            Console.WriteLine(word);
        }
    }
}
