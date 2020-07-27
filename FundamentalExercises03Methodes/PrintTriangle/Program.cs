using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n-1; i > 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintNumbersFrom1(i);
            }
            for (int j = n - 1; j > 0; j--)
            {
                PrintNumbersFrom1(j);
            }
        }

        static void PrintNumbersFrom1(int to)
        {
            for (int i = 1; i <= to; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
