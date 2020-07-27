using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Dictionary<char, int> strings = new Dictionary<char, int>();
            for (int i = 0; i < words.Count; i++)
            {
                string item = words[i];
                for (int j = 0; j < item.Length; j++)
                {
                    if (!strings.ContainsKey(item[j]))
                    {
                        strings.Add(item[j], 1);
                    }
                    else
                    {
                        strings[item[j]]++;
                    }
                }
            }

            foreach (var item in strings)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
