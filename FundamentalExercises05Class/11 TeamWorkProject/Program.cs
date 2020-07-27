using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_TeamWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int teams = int.Parse(Console.ReadLine());
            Dictionary<string, string> dataForTeams = new Dictionary<string, string>();
            for (int i = 0; i < teams; i++)
            {
                List<string> input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (dataForTeams.ContainsKey(input[0]))
                {
                    Console.WriteLine($"{input[0]} cannot create another team!");
                }
                else if (dataForTeams.ContainsValue(input[1]))
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                }
                else
                {
                    dataForTeams.Add(input[0], input[1]);
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                }
            }


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                List<string> commands = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (true)
                {

                }
            }
        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team()
        {

        }
    }

        
}
