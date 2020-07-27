using System;
using System.Collections.Generic;

namespace FundamentalExercises05Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student pesho = new Student();
            //pesho.name = "Pesho";
            //pesho.age = 16;
            //pesho.skills = new string[] { "nishto", "i", "polovina" };
            //PrintStudent(pesho);

            Console.WriteLine("How many students in the course: ");
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                students.Add(Student.ReadStudent());
            }
            
            for (int i = 0; i < n; i++)
            {
                students[i].StudentAge();
                Student.PrintStudent(students[i]);
            }

            Console.WriteLine(Student.StudentsCount);
        }

       
    }
}
