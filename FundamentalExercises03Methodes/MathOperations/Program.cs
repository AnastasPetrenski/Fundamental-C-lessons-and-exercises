using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string function = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            Calculate(function, num1, num2);
        }

        static void Calculate(string command, int num1, int num2)
        {
            if (command == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (command == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (command == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (command == "/")
            {
                Console.WriteLine(num1 / num2);
            }
        }
    }
}
