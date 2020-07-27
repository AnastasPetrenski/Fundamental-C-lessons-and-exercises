using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18_SoftUniCourPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //we can separate the input by ", " and skip the StringBuilder.Trim()
            for (int i = 0; i < schedule.Count; i++)
            {
                string item = schedule[i];
                if (item.StartsWith(" "))
                {
                    StringBuilder removeFirstIndex = new StringBuilder();

                    for (int j = 0; j < item.Length - 1; j++)
                    {
                        removeFirstIndex.Append(item[j]);
                    }
                    schedule[i] = removeFirstIndex.ToString().Trim();
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "course start")
            {
                List<string> commands = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string exercise = $"{commands[1]}-Exercise";
                if (commands.Contains("Add") && schedule.IndexOf(commands[1]) == -1)
                {
                    schedule.Add(commands[1]);
                }
                else if (commands.Contains("Insert") && !schedule.Contains(commands[1]))
                {
                    schedule.Insert(int.Parse(commands[2]), commands[1]);
                }
                else if (commands.Contains("Remove") && schedule.Contains(commands[1]))
                {
                    schedule.Remove(commands[1]);
                    if (schedule.Contains(exercise))
                    {
                        schedule.Remove(exercise);
                    }
                }
                else if (commands.Contains("Swap") && schedule.Contains(commands[1]) && schedule.Contains(commands[2]))
                {
                    string temp = schedule[schedule.IndexOf(commands[1])];
                    int indexTemp = schedule.IndexOf(temp);
                    string second = schedule[schedule.IndexOf(commands[2])];
                    int indexSecond = schedule.IndexOf(second);
                    string exerciseSecond = $"{commands[2]}-Exercise";
                    schedule[indexTemp] = schedule[indexSecond];
                    schedule[indexSecond] = temp;
                    if (schedule.Contains(exercise) && schedule.Contains(exerciseSecond))
                    {
                        schedule[indexTemp +1] = exerciseSecond;
                        schedule[indexSecond + 1] = exercise;

                    }
                    else if (!schedule.Contains(exercise) && schedule.Contains(exerciseSecond))
                    {
                        schedule.Remove(exerciseSecond);
                        if (indexTemp + 1 < schedule.Count - 1)
                        {
                            schedule.Insert(indexTemp + 1, exerciseSecond);
                        }
                        else
                        {
                            schedule.Add(exerciseSecond);
                        }
                        
                    }
                    else if (schedule.Contains(exercise) && !schedule.Contains(exerciseSecond))
                    {
                        schedule.Remove(exercise);
                        if (indexSecond + 1 < schedule.Count - 1)
                        {
                            schedule.Insert(indexSecond + 1, exercise);
                        }
                        else
                        {
                            schedule.Add(exercise);
                        }
                        
                    }
                }
                else if (commands.Contains("Exercise"))
                {
                    if (schedule.Contains(commands[1]) && schedule.IndexOf(exercise) == -1)
                    {
                        schedule.Insert(schedule.IndexOf(commands[1]) + 1, exercise);
                    }
                    else if (!schedule.Contains(commands[1]) && schedule.IndexOf(exercise) == -1)
                    {
                        schedule.Add(commands[1]);
                        schedule.Add(exercise);
                    }
                    else if (!schedule.Contains(commands[1]) && schedule.Contains(exercise))
                    {
                        schedule.Insert(schedule.IndexOf(exercise), commands[1]);
                    }
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }

        }
    }
}
