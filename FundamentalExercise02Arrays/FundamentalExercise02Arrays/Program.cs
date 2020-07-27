using System;
using System.Globalization;

namespace FundamentalExercise02Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            //var addDays = startDate.AddDays(2);

            //Console.WriteLine(addDays);

            //int singleDayInput = int.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            string day = DateTime.Now.DayOfWeek.ToString();
            string dayNumberOfMonth = DateTime.Now.Day.ToString();
            DateTime nextDay = now.AddDays(1);
            var newDay = nextDay.DayOfWeek.ToString();

            Console.WriteLine(now);
            Console.WriteLine(day);
            Console.WriteLine(dayNumberOfMonth);
            Console.WriteLine($"{nextDay} {newDay}");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(now.DayOfWeek.ToString());
                Console.WriteLine(now.ToString("dddd"));
                Console.WriteLine();
                now = now.AddDays(1);
            }
        }
    }
}
