using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_PockemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> removedIndexes = new List<int>();
            while (numbers.Count != 0)
            {

                int index = int.Parse(Console.ReadLine());
                int item = 0;
                if (index < 0 && numbers.Count != 0)
                {
                    item = numbers[0];
                    removedIndexes.Add(numbers[0]);
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (index > numbers.Count - 1 && numbers.Count != 0)
                {
                    item = numbers[numbers.Count - 1];
                    removedIndexes.Add(numbers[numbers.Count - 1]);
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    item = numbers[index];
                    removedIndexes.Add(item);
                    numbers.RemoveAt(index);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= item)
                    {
                        numbers[i] += item;
                    }
                    else
                    {
                        numbers[i] -= item;
                    }
                }


            }
            Console.WriteLine(removedIndexes.Sum());
        }
    }
}
