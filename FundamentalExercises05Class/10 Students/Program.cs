using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                students.Add(Student.ReadStudent(input));
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            Student.PrintStudents(students);
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student()
        {

        }

        public static Student ReadStudent(List<string> input)
        {
            Student student = new Student();
            student.FirstName = input[0];
            student.LastName = input[1];
            student.Grade = double.Parse(input[2]);
            return student;
        }

        public static List<Student> OrderByDescending(List<Student> students)
        {
            List<Student> ordered = new List<Student>();
            ordered = students.OrderByDescending(x => x.Grade).ToList();
            return ordered;
        }

        public static void PrintStudents(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }
}
