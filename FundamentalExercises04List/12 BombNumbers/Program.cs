using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadAndCreatList();
            List<int> commands = ReadAndCreatList();
            List<int> bombIndexes = new List<int>();
            int item = commands[0];
            int index = 0;
            if (numbers.Contains(item))
            {
                index = numbers.IndexOf(item, index);
                bombIndexes.Add(index);
            }
            else
            {
                Console.WriteLine(numbers.Sum());
                return;
            }
            
            while (numbers.Contains(item))
            {
                for (int i = 0; i < bombIndexes.Count; i++)
                {
                    int rangeBombLeft = bombIndexes[i] - commands[1];
                    int rangeBombRight = bombIndexes[i] + commands[1];

                    if (rangeBombLeft < 0 && rangeBombRight <= numbers.Count - 1)
                    {
                        //rangeBombLeft = rangeBombLeft + Math.Abs(bombIndexes[i]);
                        for (int j = 0; j <= rangeBombRight; j++)
                        {
                            numbers.Remove(numbers[0]);
                        }
                    }
                    else if (rangeBombLeft >= 0 && rangeBombRight > numbers.Count - 1)
                    {
                        for (int j = numbers.Count - 1; j >= rangeBombLeft; j--)
                        {
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                    else if (rangeBombLeft >= 0 && rangeBombRight <= numbers.Count - 1)
                    {
                        int range = rangeBombRight - rangeBombLeft + 1;
                        numbers.RemoveRange(rangeBombLeft, range);
                    }
                    else
                    {
                        for (int j = numbers.Count - 1; j >= 0; j--)
                        {
                            numbers.Remove(numbers[0]);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }

        static List<int> ReadAndCreatList()
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            return list;
        }
    }
}
