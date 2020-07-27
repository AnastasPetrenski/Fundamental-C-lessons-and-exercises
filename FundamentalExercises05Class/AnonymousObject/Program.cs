using System;

namespace AnonymousObject
{
    class Program
    {
        static void Main(string[] args)
        {

            //anonymous type a - using for testing, coz you can paste to an method
            var student = new { name = "Pesho", age = 13, skills = new string[0] };
            Console.WriteLine(student.age);

            var birthday = new Birthday() {Day = 22, Month = 05, Year = 1990};
            Console.WriteLine(birthday.Day);
        }

        public class Birthday
        {
           public int Day;
           public int Month;
           public int Year;
        }
    }
}
