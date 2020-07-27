using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int result = 0;

            foreach (var digit in number)
            {
                result += FindFactoriel(digit.ToString());
            }

            if (result == int.Parse(number))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }

        static int FindFactoriel(string digit)
        {
            int result = 1;

            for (int i = 1; i <= int.Parse(digit); i++)
            {
                result *= i;
            }
            return result;
        }
    }
}