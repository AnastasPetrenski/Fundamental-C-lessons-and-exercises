using System;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student peshoStudent = new Student() 
            //{ 
            //    Name = "Pesho", 
            //    Age = 18, 
            //    Skills = new string[] { "1", "2", "3" } 
            //};

            //Static method which replace aforementioned code 
            Student peshoStudent = Student.ReadStudent();

            //student.PrintStudent(student); <-- if the method is not static
            Console.WriteLine(peshoStudent.Age);
            //Method of an object of the Class Student, instance student
            peshoStudent.AgeStudent();
            peshoStudent.AgeStudent();
            Console.WriteLine(peshoStudent.Age);
            //Method of the class Student, not of the instance "student"
            Student.PrintStudent(peshoStudent);
        }
    }
}
