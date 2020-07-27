using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double j = double.Parse(Console.ReadLine());
            double result = FactorialDivision(n, j);
            Console.WriteLine($"{result:f2}");
           

            static double FactorialDivision(double n, double j)
            {
                return FactorialNumber1(n) / FactorialNumber1(j);
            }

            static double FactorialNumber1(double n)
            {
                double sum = 1;
                for (double i = n; i > 0; i--)
                {
                    sum *= i;
                }
                return sum;
            }

            //static double FactorialNumber2(double j)
            //{
            //    double sum = 1;
            //    for (double x = j; x > 0; x--)
            //    {
            //        sum *= x;
            //    }
            //    return sum;
            //}
        }
    }
}
