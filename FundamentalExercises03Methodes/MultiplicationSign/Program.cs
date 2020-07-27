using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal num3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReturnTypeOfNumber(num1, num2, num3)); 
        }

        static string ReturnTypeOfNumber(decimal num1, decimal num2, decimal num3)
        {
            string numberType = string.Empty;            
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                numberType = "zero";
            }
            else if ((num1 < 0 && num2 < 0 && num3 > 0) || (num1 < 0 && num2 > 0 && num3 < 0) || (num1 > 0 && num2 < 0 && num3 < 0) || (num1 > 0 && num2 > 0 && num3 > 0))
            {
                numberType = "positive";
            }
            else 
            {
                numberType = "negative";
            }

            return numberType;
        }
    }
}
