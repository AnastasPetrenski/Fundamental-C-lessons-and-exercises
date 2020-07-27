using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Student
    {
        public string Name;
        public int Age;
        public string[] Skills;

        //Method of the instance, when dont have declaration "static"
        public void AgeStudent()
        {
            this.Age++;
        }

        //Method of the class, we dont need of new instance to invoce the method
        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name: {student.Name}; student age: {student.Age}; student skills: {string.Join(" ", student.Skills)}");
        }

        public static Student ReadStudent()
        {
            Student newStudent = new Student();

            Console.WriteLine("Write name: ");
            newStudent.Name = Console.ReadLine();

            Console.WriteLine("Write age: ");
            newStudent.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Write skills: ");
            newStudent.Skills = Console.ReadLine().Split();

            Console.WriteLine(newStudent);
            return newStudent;
        }
    }
}
