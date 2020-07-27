using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> contests = new Dictionary<string, int>();
            List<Student> students = new List<Student>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "no more time")
            {
                //Pesho -> Algo -> 400
                List<string> input = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (students.Any(x => x.Contest == contest))
                {
                    bool addInput = true;
                    foreach (var student in students.Where(x => x.Contest == contest))
                    {
                        if (student.Contest == contest && student.Name == name && student.Points < points)
                        {
                            student.Points = points;
                            addInput = false;
                            continue;
                        }
                        else if (student.Contest == contest && student.Name == name && student.Points >= points)
                        {
                            addInput = false;
                        }
                    }
                    if (addInput)
                    {
                        students.Add(Student.AddStudent(input));
                        if (!contests.ContainsKey(input[1]))
                        {
                            contests.Add(input[1], 1);
                        }
                        else if (contests.ContainsKey(input[1]))
                        {
                            contests[input[1]]++;
                        }
                    }
                }
                else
                {
                    students.Add(Student.AddStudent(input));
                    if (!contests.ContainsKey(input[1]))
                    {
                        contests.Add(input[1], 1);
                    }
                    else if (contests.ContainsKey(input[1]))
                    {
                        contests[input[1]]++;
                    }
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value} participants");
                int position = 1;
                foreach (var student in students.Where(x => x.Contest == contest.Key).OrderByDescending(x => x.Points).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{position}. {student.Name} <::> {student.Points}");
                    position++;
                }
            }

            SortedDictionary<string, int> singleResult = new SortedDictionary<string, int>();
            foreach (var student in students)
            {
                if (!singleResult.ContainsKey(student.Name))
                {
                    var maxPoints = students.Where(x => x.Name == student.Name).Sum(x => x.Points);
                    singleResult.Add(student.Name, maxPoints);
                }
               
            }

            Console.WriteLine("Individual standings:");
            int position2 = 1;
            foreach (var item in singleResult.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{position2}. {item.Key} -> {item.Value}");
                position2++;
            }

        }
    }

    public class Student
    {
        public string Contest { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        public Student()
        {
                
        }

        public static Student AddStudent(List<string> input)
        {
            Student student = new Student();
            student.Contest = input[1];
            student.Name = input[0];
            student.Points = int.Parse(input[2]);
            return student;
        }
    }
}
