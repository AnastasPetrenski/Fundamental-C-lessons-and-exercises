using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalExercises05Class
{
    public class Student
    {   
        public static int StudentsCount;
        public string name;
        public int age;
        public string[] skills;

        public void StudentAge()
        {
            this.age++;
        }

        public static Student ReadStudent()
        {
            Student newStudent = new Student();
            Console.WriteLine("Write name: ");
            newStudent.name = Console.ReadLine();

            Console.WriteLine("Write age: ");
            newStudent.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Write skills: ");
            newStudent.skills = Console.ReadLine().Split();
            Student.StudentsCount++;
            return newStudent;
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name: {student.name}; student age: {student.age}; student skills: {string.Join(" ", student.skills)}");
        }
    }   
}
