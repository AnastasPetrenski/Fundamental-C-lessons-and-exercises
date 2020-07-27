using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = AddFirstAndSecondNumber(a, b);
            int result = SubtractThirdNumberFromResult(c, sum);
            Console.WriteLine(result);
        }

        static int SubtractThirdNumberFromResult(int inputC, int sum)
        {
            return sum - inputC;
        }

        static int AddFirstAndSecondNumber(int inputA, int inputB)
        {
            int result = inputA + inputB;
                return result;
        }
    }
}
