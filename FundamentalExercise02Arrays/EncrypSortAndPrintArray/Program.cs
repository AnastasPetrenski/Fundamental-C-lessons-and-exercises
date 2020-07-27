using System;
using System.Collections.Generic;

namespace EncrypSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringNumbers = int.Parse(Console.ReadLine());
            char[] vowelLetters = { 'a', 'A', 'E', 'e', 'i', 'I', 'u', 'U', 'o', 'O' };
            string[] consonantLetters = { "B", "b", "C", "c", "D", "d", "F", "f", "G", "g", "H", "h", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z" };
            List<int> ls = new List<int>();
            for (int i = 0; i < stringNumbers; i++)
            {
                string input = Console.ReadLine();
                char[] name = input.ToCharArray();

                int sum = 0;

                foreach (var item in name)
                {
                    bool isVowel = false;
                    for (int z = 0; z < vowelLetters.Length; z++)
                    {
                        if (item == vowelLetters[z])
                        {
                            isVowel = true;
                        }
                    }
                    if (isVowel)
                    {
                        //char convertItem = char.Parse(item);
                        sum += item * input.Length;
                    }
                    else
                    {
                        //char convertItem = char.Parse(item);
                        sum += item / input.Length;
                    }
                }

                ls.Add(sum);
            }
            ls.Sort();
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
