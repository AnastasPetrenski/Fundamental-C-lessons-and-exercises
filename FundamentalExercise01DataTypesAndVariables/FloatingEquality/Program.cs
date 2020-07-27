using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = Math.Abs(a - b);
            double aps = 0.000001;
            if (result > aps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }


        }
    }
}
