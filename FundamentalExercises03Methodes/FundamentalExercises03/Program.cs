using System;
using System.Threading;

namespace CalculatingPowerOfNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 1; i <= 120; i++)
            {
                Console.SetWindowSize(i, 40);
                Thread.Sleep(20);
            }
            //char sign = (char)1;
            for (int i = 0; i <= 100; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("█");
                    //Console.Write($"{sign}");
                }
                Console.WriteLine();
                Console.WriteLine($"{i}/100%");
                Console.SetCursorPosition(0, 1);
                Thread.Sleep(100);
            }



            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculatePower(number, power));

        }

        static double CalculatePower(double number, double power)
        {
            double result = 1.00;
            for (int i = 0; i < power; i++)
            {
                result *= number;
                
            }

            return result;
        }
    }
}
