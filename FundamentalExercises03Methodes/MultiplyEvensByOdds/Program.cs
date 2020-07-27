using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOddNumbers = SumOddNumbers(n);
            int sumEvenNumbers = SumEvenNumbers(n);
            MultiplyEvensByOdds(sumOddNumbers, sumEvenNumbers);
        }

        static int SumOddNumbers(int n)
        {
            int result = 0;
            int temp = 0;
            while (n > 0)
            {
                temp = n % 10;
                if (temp % 2 != 0)
                {
                    result += temp;
                }
                n /= 10;
            }
            return result;
        }

        static int SumEvenNumbers(int n)
        {
            int result = 0;
            int temp = 0;
            while (n > 0)
            {
                temp = n % 10;
                if (temp % 2 == 0)
                {
                    result += temp;
                }
                n /= 10;
            }
            return result;
        }

        static void MultiplyEvensByOdds(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
