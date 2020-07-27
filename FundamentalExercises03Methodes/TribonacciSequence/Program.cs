using System;
using System.Numerics;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger sum = a + b;
            
            if (input <= 0)
            {
                Console.WriteLine(0);
            }
            else if (input == 1)
            {
                Console.WriteLine(1);
            }
            else if (input == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (true)
            {
                Console.Write($"{b} {sum} ");
                for (int i = 0; i < input - 2; i++)
                {
                    BigInteger tribunacci = a + b + sum;
                    Console.Write(tribunacci + " ");
                    a = b;
                    b = sum;
                    sum = tribunacci;
                }
            }
            
        }
    }
}
