using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', ',', '.', '!', '?', '-', '/', ';' };
            List<string> bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Count; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
