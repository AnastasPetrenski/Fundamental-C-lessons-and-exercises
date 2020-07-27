using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student()
        {

        }

        public static Student ReadStudent(List<string> info)
        {
            Student singlePerson = new Student();
            singlePerson.FirstName = info[0];
            singlePerson.LastName = info[1];
            singlePerson.Age = int.Parse(info[2]);
            singlePerson.HomeTown = info[3];
            return singlePerson;
        }

        public static void PrintTown(List<Student> listOfStudents, string city)
        {
            foreach (var item in listOfStudents)
            {
                if (item.HomeTown == city)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }
        }

        public static bool IsStudentExisting(List<string> info, List<Student> members)
        {
            foreach (Student member in members)
            {
                if (member.FirstName == info[0] && member.LastName == info[1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
