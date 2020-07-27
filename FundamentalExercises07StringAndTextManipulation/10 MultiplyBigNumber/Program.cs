using System;
using System.Numerics;
using System.Text;

namespace _10_MultiplyBigNumber
{
    class Program
    {
        public static object StringBulder { get; private set; }

        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            //BigInteger fx = BigInteger.Parse(number) * 9;
            //Console.WriteLine(fx);
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int remainder = 0;
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentDigit = (number[i] - '0');
                int multiply = n * currentDigit;
                if (multiply <= 9)
                {
                    if (remainder > 0)
                    {
                        if ((multiply + remainder) > 9)
                        {
                            int lastDigit = ((multiply + remainder) % 10);
                            result.Insert(0, lastDigit);
                            remainder = (multiply + remainder) / 10;
                        }
                        else
                        {
                            int lastDigit = multiply + remainder;
                            result.Insert(0, lastDigit);
                            remainder = 0;
                        }
                    }
                    else
                    {
                        result.Insert(0, multiply);
                    }

                }
                else
                {
                    if (remainder > 0)
                    {
                        int lastDigit = (multiply % 10) + remainder;
                        if (lastDigit > 9)
                        {
                            int tempNumber = lastDigit;
                            lastDigit = lastDigit % 10;
                            result.Insert(0, lastDigit);
                            remainder = (multiply / 10) + (tempNumber / 10);
                        }
                        else
                        {
                            result.Insert(0, lastDigit);
                            remainder = multiply / 10;
                        }
                    }
                    else
                    {
                        int lastDigit = (multiply % 10);
                        result.Insert(0, lastDigit);
                        remainder = multiply / 10;
                    }
                }
            }
            if (remainder > 0)
            {
                result.Insert(0, remainder);
            }
            Console.WriteLine(result);
        }
    }
}
