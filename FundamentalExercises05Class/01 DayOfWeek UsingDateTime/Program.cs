using System;
using System.Globalization;

namespace _01_DayOfWeek_UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
            //Console.WriteLine(date.DayOfYear);
            //Console.WriteLine(date.Day);
        }
    }
}
