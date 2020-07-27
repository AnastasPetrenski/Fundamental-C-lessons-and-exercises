using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            Dictionary<string, double> sorted = new Dictionary<string, double>();
            foreach (var item in students)
            {
                double avg = item.Value.Average();
                if (avg >= 4.50)
                {
                    sorted.Add(item.Key, avg);
                }
            }

            foreach (var item in sorted.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
