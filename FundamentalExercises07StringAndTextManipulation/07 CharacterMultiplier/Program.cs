using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Multiplier(input[0], input[1]);
        }

        public static void Multiplier(string first, string second)
        {
            int max = Math.Max(first.Length, second.Length);
            int result = 0;
            for (int i = 0; i < max; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    result += first[i] * second[i];
                }
                else if (i < first.Length)
                {
                    result += first[i];
                }
                else if (i < second.Length)
                {
                    result += second[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
