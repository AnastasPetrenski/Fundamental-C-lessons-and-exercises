using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NumberType(n);
        }

        static void NumberType(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
