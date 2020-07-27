using System;
using System.Collections.Generic;
using System.Linq;

namespace _21_TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            List<char> input = Console.ReadLine().ToList();

            //separate digits from the input and store them in another list
            List<string> numbers = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    numbers.Add(input[i].ToString());
                    input.RemoveAt(i);
                    i--;
                }
            }
          
            //split digits in two lists - depending on whether the digit is in an even - (take list) or an odd - (skip list) index
            //List<int> take = new List<int>();
            //List<int> skip = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        take.Add(int.Parse(numbers[i]));
            //    }
            //    else
            //    {
            //        skip.Add(int.Parse(numbers[i]));
            //    }
            //}

            //iterate over the both lists skip{skipCount} and take{takeCount} characters. Store taken characters in an list
            // --> every iteration are summed and we start counting from where we stopped
            List<string> message = new List<string>();
            string expression = string.Empty;
            foreach (var item in input)
            {
                expression += item;
            }

            int indexCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int curCount = int.Parse(numbers[i]);
                if (i % 2 == 0)
                {
                    if (indexCount + curCount > expression.Length)
                    {
                        curCount = expression.Length - indexCount;
                    }
                    if (curCount < 0)
                    {
                        break;
                    }
                    message.Add(expression.Substring(indexCount, curCount));
                }
                indexCount += int.Parse(numbers[i]);
            }
            
            //Print result from taken list
            Console.WriteLine(string.Join("", message));
        }
    }
}
