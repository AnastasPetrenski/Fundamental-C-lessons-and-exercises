using System;

namespace MultiplyEvensByOddsNewMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            MultiplyEvenAndOddSums(n);
        }

        static int MultiplyEvenAndOddSums(int n)
        {
            return CalculateOddNumbersSum(n, 0) * CalculateOddNumbersSum(n, 1);
        }

        static int CalculateOddNumbersSum(int n, int isOdd)
        {
            string number = n.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse(number[i].ToString());
                if (currentDigit % 2 == isOdd)
                {
                    sum += currentDigit;
                }
            }

            return sum;
        }
    }
}
