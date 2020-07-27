using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateType = Console.ReadLine();
            if (dateType == "int")
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(ExecuteProperOperation(input)); 
            }
            else if (dateType == "real")
            {
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ExecuteProperOperation(input):f2}");
            }
            else if (dateType == "string")
            {
                string input = Console.ReadLine();
                Console.WriteLine($"${input}$");
            }
        }

        static int ExecuteProperOperation(int input)
        {
            int result = input * 2;
            return result;
        }

        static double ExecuteProperOperation(double input)
        {
            double result = input * 1.50;
            return result;

        }
    }
}
