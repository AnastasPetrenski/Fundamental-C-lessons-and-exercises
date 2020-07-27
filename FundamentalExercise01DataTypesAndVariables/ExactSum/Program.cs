using System;
using System.Linq;
using System.Numerics;

namespace ExactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
