using System;
using System.Collections.Generic;
using System.Linq;

namespace _18_MobbaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            string command = string.Empty;
            string removePLayer = string.Empty;
            while ((command = Console.ReadLine()) != "Season end")
            {
                List<string> input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                //Add player
                if (input.Contains("->"))
                {
                    input = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();
                    string name = input[0];
                    string position = input[1];
                    int points = int.Parse(input[2]);

                    if (players.Any(x => x.Name == name))
                    {
                        bool addInput = true;
                        foreach (var player in players)
                        {
                            if (player.Name == name && player.Position == position && player.Skill < points)
                            {
                                player.Skill = points;
                                addInput = false;
                                break;
                            }
                            else if (player.Name == name && player.Position == position && player.Skill >= points)
                            {
                                addInput = false;
                                break;
                            }
                        }
                        if (addInput)
                        {
                            players.Add(Player.AddPLayer(input));
                        }
                    }
                    else
                    {
                        players.Add(Player.AddPLayer(input));
                    }

                }
                //Fight - remove if necessary
                else if (input.Contains("vs"))
                {
                    input = command.Split(" vs ", StringSplitOptions.RemoveEmptyEntries).ToList();
                    string firstPlayer = input[0];
                    string secondPlayer = input[1];
                    int firstPlayerPoints = players.Where(x => x.Name == firstPlayer).Sum(x => x.Skill);
                    int secondPlayerPoints = players.Where(x => x.Name == secondPlayer).Sum(x => x.Skill);
                    List<string> positions = players.Select(x => x.Position).Distinct().ToList();
                    if ((players.Any(x => x.Name.Contains(firstPlayer))) && (players.Any(x => x.Name == secondPlayer)))
                    {
                        int n = 0;
                        foreach (var position in positions)
                        {
                            if ((players.Where(x => x.Name == firstPlayer).Any(x => x.Position.Contains(positions[n]))) &&
                            (players.Where(x => x.Name == secondPlayer).Any(x => x.Position.Contains(positions[n]))))
                            {
                                if (firstPlayerPoints > secondPlayerPoints)
                                {
                                    removePLayer = secondPlayer;
                                    break;
                                }
                                else if (secondPlayerPoints > firstPlayerPoints)
                                {
                                    removePLayer = firstPlayer;
                                    break;
                                }
                            }
                            n++;
                        }
                    }
                }

                players.RemoveAll(x => x.Name == removePLayer);
            }

            //Print
            var maxSkill = 0;
            List<string> playerNames = players.Select(x => x.Name).Distinct().ToList();
            Dictionary<string, int> maxSkills = new Dictionary<string, int>();
            foreach (var name in playerNames)
            {
                 maxSkill = players.Where(x => x.Name == name).Sum(x => x.Skill);
                maxSkills.Add(name, maxSkill);
            }

            foreach (var item in maxSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} skill");
                foreach (var player in players.Where(x => x.Name == item.Key).OrderByDescending(x => x.Skill).ThenBy(x => x.Position))
                {
                    Console.WriteLine($"- {player.Position} <::> {player.Skill}");
                }
            }
        }
    }
}

public class Player
{
    public string Name { get; set; }
    public string Position { get; set; }
    public int Skill { get; set; }

    public Player()
    {

    }

    public static Player AddPLayer(List<string> input)
    {
        Player player = new Player();
        player.Name = input[0];
        player.Position = input[1];
        player.Skill = int.Parse(input[2]);
        return player;
    }
}

