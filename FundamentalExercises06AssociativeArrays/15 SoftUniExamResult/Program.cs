using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_SoftUniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> exam = new List<Student>(); 
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                List<string> input = command.Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!input.Contains("banned"))
                {
                    exam.Add(Student.AddStudent(input));
                }
                else
                {
                    exam.Where(x => x.UserName == input[0]).Select(x => x.Bann = true).ToList();
                }
            }

            List<string> names = exam.Where(x => x.Bann == false).Select(x => x.UserName).Distinct().ToList();
            Dictionary<string, List<int>> distinct = new Dictionary<string, List<int>>();
            Dictionary<string, int> ordered = new Dictionary<string, int>();
            foreach (var item in names)
            {
                distinct.Add(item, new List<int>());
                foreach (var obj in exam)
                {
                    if (obj.UserName == item)
                    {
                        distinct[item].Add(obj.Points);
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in distinct)
            {
                ordered.Add(item.Key, item.Value.Max());
            }
            foreach (var item in ordered.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            List<string> lang = exam.Select(x => x.Language).Distinct().ToList();
            Dictionary<string, int> results = new Dictionary<string, int>();        
            for (int i = 0; i < lang.Count; i++)
            {
                results.Add(lang[i], 0);
                
                foreach (var item in exam)
                {
                    if (item.Language == lang[i])
                    {
                        results[lang[i]]++;
                    }
                }
            }

            Console.WriteLine("Submissions:");
            foreach (var item in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }

    class Student
    {
        public string UserName { get; set; }
        public string Language { get; set; }
        public int Points { get; set; }
        public bool Bann { get; set; }

        public Student()
        {

        }

        public static Student AddStudent(List<string> input)
        {
            Student student = new Student();
            student.UserName = input[0];
            student.Language = input[1];
            student.Points = int.Parse(input[2]);
            student.Bann = false;
            return student;
        }
    }
}
