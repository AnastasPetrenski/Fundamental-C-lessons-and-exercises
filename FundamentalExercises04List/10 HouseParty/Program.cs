using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            List<string> listOfGuests = new List<string>();
            for (int i = 0; i < guests; i++)
            {
                List<string> commands = ReadAndCreatList();
                if (commands.Contains("not"))
                {
                    CaseGuestNotGoing(listOfGuests, commands);
                }
                else
                {
                    CaseGuestIsGoing(listOfGuests, commands);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, listOfGuests));
            
        }
        
        static List<string> ReadAndCreatList()
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            return list;
        }

        static void CaseGuestNotGoing(List<string> listOfGuests, List<string> commands)
        {
            if (listOfGuests.Contains(commands[0]))
            {
                listOfGuests.Remove(commands[0]);
            }
            else
            {
                Console.WriteLine($"{commands[0]} is not in the list!");
            }
        }

        static void CaseGuestIsGoing(List<string> listOfGuests, List<string> commands)
        {
            if (listOfGuests.Contains(commands[0]))
            {
                Console.WriteLine($"{commands[0]} is already in the list!");
            }
            else
            {
                listOfGuests.Add(commands[0]);
            }
        }
        
    }
}
