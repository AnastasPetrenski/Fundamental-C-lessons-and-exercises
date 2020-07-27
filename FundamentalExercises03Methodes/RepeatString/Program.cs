using System;
using System.Diagnostics;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStringFaster(input, repeatTimes));

            Stopwatch timer = Stopwatch.StartNew();
            RepeatStringFaster(input, repeatTimes);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

        static string RepeatStringFaster(string toRepeat, int times) 
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(toRepeat);
            }

            return result.ToString();
        }
    }
}
