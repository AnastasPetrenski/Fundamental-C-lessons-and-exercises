using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MatrixOfNumberN(n);
        }

        static void MatrixOfNumberN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintMatrix(n);
            }
        }

        static void PrintMatrix(int n)
        {
            for (int k = 1; k <= n; k++)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
