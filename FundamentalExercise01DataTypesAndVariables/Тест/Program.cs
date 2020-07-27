using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 1; num <= number; num++)
            {
                int sum = 0;
                int digits = num;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                if (sum == 0)
                {
                    continue;
                }
                else if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }
            }
        }
    }
}