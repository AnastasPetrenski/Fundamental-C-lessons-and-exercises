using System;

namespace RefacorSpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int totalSum = 0;
            //int temp = 0;
            bool isSpecial = false;
            for (int ch = 1; ch <= input; ch++)
            {
                int temp = ch;
                while (ch > 0)
                {
                    totalSum += ch % 10;
                    ch = ch / 10;
                }
                isSpecial = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);
                Console.WriteLine("{0} -> {1}", temp, isSpecial);
                totalSum = 0;
                ch = temp;
            }

        }
    }
}
