using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Student> listOfStudents = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> info = input.Split().ToList();
                //bool exist = IsStudentExisting(info, listOfStudents);
                if (Student.IsStudentExisting(info, listOfStudents))
                {
                    Student existingStudent = listOfStudents.FirstOrDefault(x => x.FirstName == info[0] && x.LastName == info[1]);
                    existingStudent.FirstName = info[0];
                    existingStudent.LastName = info[1];
                    existingStudent.Age = int.Parse(info[2]);
                    existingStudent.HomeTown = info[3];
                }
                else
                {
                    listOfStudents.Add(Student.ReadStudent(info));
                }

            }
            string city = Console.ReadLine();

            Student.PrintTown(listOfStudents, city);
        }
    }
}
