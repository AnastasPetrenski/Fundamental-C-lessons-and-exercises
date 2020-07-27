using System;
using System.Collections.Generic;
using System.Linq;

namespace _19_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<char> word = Console.ReadLine().ToList();
            string number = string.Empty;
            List<string> expression = new List<string>();
            foreach (var item in input)
            {
                int sum = 0;
                number = item;
                for (int i = 0; i < number.Length; i++)
                {
                    sum += number[i] - '0';
                }

                int index = 0;
                if (sum > word.Count)
                {
                    int n = sum / word.Count;
                    index = sum - (n * word.Count);
                }
                else
                {
                    index = sum;
                }

                //if (expression.Count == 0)
                //{
                //    expression.Add(word[index].ToString().ToUpper());
                //    word.RemoveAt(index);
                //}
                //else
                //{
                expression.Add(word[index].ToString());
                word.RemoveAt(index);
                //}
            }

            Console.WriteLine(string.Join("", expression));
        }
    }
}
