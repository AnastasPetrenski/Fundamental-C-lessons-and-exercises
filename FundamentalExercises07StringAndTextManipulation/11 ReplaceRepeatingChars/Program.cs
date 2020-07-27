using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().ToList();
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    input.RemoveAt(i + 1);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}
