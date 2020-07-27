using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int coursesNecessary = 0;
            coursesNecessary = (int)Math.Ceiling(people * 1.00 / capacity);
            Console.WriteLine(coursesNecessary);
        }
    }
}
