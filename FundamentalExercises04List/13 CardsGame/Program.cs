using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = ReadAndCreateList();
            List<int> secondPlayerCards = ReadAndCreateList();
            while (firstPlayerCards.Count != 0 || secondPlayerCards.Count != 0)
            {
                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondPlayerCards[0]);
                }
                else if (firstPlayerCards[0] < secondPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(firstPlayerCards[0]);
                }

                firstPlayerCards.Remove(firstPlayerCards[0]);
                secondPlayerCards.Remove(secondPlayerCards[0]);

                if (firstPlayerCards.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
                    break;
                }
                else if (secondPlayerCards.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
                    break;
                }
            }
        }

        static List<int> ReadAndCreateList()
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            return list;
        }
    }    
}
