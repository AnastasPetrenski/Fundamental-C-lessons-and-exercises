using System;
using System.Collections.Generic;

namespace _10_MultiplyBigNumberSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart(new char[] { '0'});
            int operand = int.Parse(Console.ReadLine());
            int remainder = 0;
            List<int> result = new List<int>();
            if (operand == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentDigit = number[i] - '0';
                int multiplied = currentDigit * operand;
                multiplied += remainder;
                result.Add(multiplied % 10);
                remainder = multiplied / 10;
            }
            if (remainder>0)
            {
                result.Add(remainder);
            }
            result.Reverse();
            Console.Write(string.Join("", result));
        }
    }
}
