using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] dayOfWeek = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            string chosenDay = string.Empty;
            //Console.WriteLine(dayOfWeek[day-1]);
            if (day >= 1 && day <= 7)
            {
                for (int i = 0; i < dayOfWeek.Length; i++)
                {
                    chosenDay = (dayOfWeek[day - 1]);
                }
            }
            
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(chosenDay);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
