using System;
using System.Collections.Generic;

namespace _03_WordSynonymos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonymos = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonymos);
                }
                else
                {
                    words[word].Add(synonymos);
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
