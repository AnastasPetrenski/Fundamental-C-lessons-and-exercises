using System;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopDigits(n);
        }

        static void TopDigits(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string singleDigit = i.ToString();
                if (SumOfSingleDigits(singleDigit) && 
                    CheckForOddDigitContent(singleDigit))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfSingleDigits(string singleDigit)
        {
            int sum = 0;
            bool isDivisible = false;
            string curr = singleDigit;
            for (int j = 0; j < curr.Length; j++)
            {
                sum += curr[j] - '0';
            }

            if (sum % 8 == 0)
            {
                isDivisible = true;
            }

            return isDivisible;

        }

        static bool CheckForOddDigitContent(string singleDigit)
        {
            bool isOdd = false;
            string curr = singleDigit;
            for (int i = 0; i < curr.Length; i++)
            {
                int digit = Convert.ToInt32(curr[i]);
                if (digit % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
            }
            return isOdd;
        }



    }
}
