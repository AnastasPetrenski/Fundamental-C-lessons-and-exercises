using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            for (int i = 0; i < words.Count; i++)
            {
                words[i] = words[i].ToLower();
            }


            Dictionary<string, int> collection = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if(collection.ContainsKey(word))
                {
                    collection[word]++;
                }
                else
                {
                    collection.Add(word, 1);
                }
            }

            StringBuilder result = new StringBuilder();
            foreach (var item in collection)
            {
                if (item.Value % 2 == 0)
                {
                    continue;
                }
                else
                {
                    result.Append(item.Key);
                    result.Append(" ");
                }
            }
            Console.WriteLine(result);
        }
    }
}
