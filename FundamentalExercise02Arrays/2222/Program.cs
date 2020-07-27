using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] field = new int[sizeOfField];
            int[] ladybugsPositions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                if (field.Length > ladybugsPositions[i])
                {
                    for (int x = 0; x <= ladybugsPositions[i]; x++)
                    {
                        if (x == ladybugsPositions[i])
                        {
                            field[x] = 1;
                        }
                    }
                }
                if (i + 1 == ladybugsPositions.Length)
                {
                    break;
                }

            }
            //Console.WriteLine(string.Join(" ", field));
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybug = Convert.ToInt32(command[0]);
                string direction = command[1];
                int flyLength = Convert.ToInt32(command[2]);



            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
