using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_TeamWorkProjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsNumber = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < teamsNumber; i++)
            {
                List<string> inputTeams = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (teams.Any(x => x.TeamName == inputTeams[1]))
                {
                    Console.WriteLine($"Team {inputTeams[1]} was already created!");
                }
                else if (teams.Any(x => x.Creator == inputTeams[0]))
                {
                    Console.WriteLine($"{inputTeams[1]} cannot create another team!");
                }
                else
                {
                    teams.Add(Team.ReadTeam(inputTeams));
                    Console.WriteLine($"Team {inputTeams[1]} has been created by {inputTeams[0]}!");
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                List<string> commands = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToList();
                string person = commands[0];
                string team = commands[1];
                if (!teams.Any(x => x.TeamName == commands[1]))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(person)) || teams.Select(x => x.Creator).Contains(person))
                {
                    Console.WriteLine($"Member {person} cannot join team {team}!");
                }
                else
                {
                    //teams = teams.Find(x => x.TeamName == team).Members.Add(person).ToList();
                    foreach (var item in teams)
                    {
                        if (item.TeamName == team)
                        {
                            item.Members.Add(person);
                        }
                    }
                }
            }

            List<Team> ordered = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).Where(x => x.Members.Count > 0).ToList();
            List<Team> disbaned = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0).ToList();
            Team.PrintTeams(ordered, disbaned);
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

    public static Team ReadTeam(List<string> commands)
    {
        Team team = new Team();
        team.TeamName = commands[1];
        team.Creator = commands[0];
        team.Members = new List<string>();
        return team;
    }

    public static void PrintTeams(List<Team> teams, List<Team> disbaned)
    {
        foreach (var team in teams)
        {
            Console.WriteLine($"{team.TeamName}");
            Console.WriteLine($"- {team.Creator}");
            foreach (var member in team.Members.OrderBy(x => x))
            {
                Console.WriteLine($"-- {member}");
            }
        }
        Console.WriteLine("Teams to disband:");
        foreach (var item in disbaned)
        {
            Console.WriteLine(item.TeamName);
        }
    }
}
