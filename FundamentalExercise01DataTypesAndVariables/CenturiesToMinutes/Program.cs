using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int houres = days * 24;
            decimal minutes = houres * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {houres} hours = {minutes} minutes");
        }
    }
}
