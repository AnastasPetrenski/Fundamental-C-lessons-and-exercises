using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> results = new List<Candidate>();
            Dictionary<string, string> contestInfo = new Dictionary<string, string>();
            string stopRecord = string.Empty;
            while ((stopRecord = Console.ReadLine()) != "end of contests")
            {
                List<string> input = stopRecord.Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!contestInfo.ContainsKey(input[0]))
                {
                    contestInfo.Add(input[0], input[1]);
                }
            }
            //“{contest}=>{password}=>{username}=>{points}” until you receive "end of submissions"
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                List<string> input = command.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToList();
                string contest = input[0];
                string password = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);

                if (contestInfo.ContainsKey(contest) && contestInfo[contest] == password)
                {
                    if (results.Any(x => x.Contest == contest))
                    {
                        bool addInput = true;
                        foreach (var item in results.Where(x => x.Contest == contest))
                        {
                            if (item.Contest == contest && item.Users == username && item.Grades < points)
                            {
                                item.Grades = points;
                                addInput = false;
                            }
                            else if (item.Contest == contest && item.Users == username && item.Grades >= points)
                            {
                                addInput = false;
                            }
                        }
                        if (addInput)
                        {
                            results.Add(Candidate.AddCandidate(input));
                        }
                    }
                    else 
                    {
                        results.Add(Candidate.AddCandidate(input));
                    }

                }
            }

            List<string> users = results.Select(x => x.Users).Distinct().ToList();
            int bestGrade = int.MinValue;
            string bestUser = string.Empty;
            foreach (var item in users)
            {
                var sum = results.Where(x => x.Users == item).Sum(x => x.Grades);
                if (sum > bestGrade)
                {
                    bestGrade = sum;
                    bestUser = item;
                }
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {bestGrade} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in users.OrderBy(x => x))
            {
                Console.WriteLine(user);
                foreach (var item in results.Where(x => x.Users == user).OrderByDescending(x => x.Grades))
                {
                    Console.WriteLine($"#  {item.Contest} -> {item.Grades}");
                }
            }

        }
    }

    public class Candidate
    {
        public string Contest { get; set; }
        public string Users { get; set; }
        public int Grades { get; set; }

        public Candidate()
        {

        }

        public static Candidate AddCandidate(List<string> input)
        {
            Candidate candidate = new Candidate();
            candidate.Contest = input[0];
            candidate.Users = input[2];
            candidate.Grades = int.Parse(input[3]);
            return candidate;
        }
    }
}
