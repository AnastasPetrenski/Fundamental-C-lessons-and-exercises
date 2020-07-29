using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10_WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex validTicket = new Regex(@"([$@#\^]{6,10})");
            List<string> tickets = Console.ReadLine().Split(new char[] {',',' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].Length == 20)
                {
                    string firstPart = tickets[i].Substring(0, 10);
                    string secondPart = tickets[i].Substring(10, 10);
                    var matchFirstPart = validTicket.Match(firstPart);
                    var matchSecondPart = validTicket.Match(secondPart);
                    if (validTicket.IsMatch(firstPart) && validTicket.IsMatch(secondPart))
                    {
                        TicketValidating(matchFirstPart, matchSecondPart, tickets[i]);
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }
        }

        public static void TicketValidating(Match firstPart, Match secondPart, string ticket)
        {
            string first = firstPart.Value;
            string second = secondPart.Value;
            if (first.Length == second.Length && first.Length >= 6 && first.Length <= 9 && first[0] == second[0])
            {
                Console.WriteLine($"ticket \"{ticket}\" - {first.Length}{first[0]}");
            }
            else if (first.Length != second.Length && first.Length >= 6 && first.Length <= 10 && first[0] == second[0] && second.Length >= 6 && second.Length <= 10)
            {
                Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(first.Length, second.Length)}{first[0]}");
            }
            else if (first.Length == second.Length && first.Length == 10 && first[0] == second[0])
            {
                Console.WriteLine($"ticket \"{ticket}\" - {first.Length}{first[0]} Jackpot!");
            }
            else
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}
