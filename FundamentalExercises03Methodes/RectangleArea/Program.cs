using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateArea(width, height));
        }

        static int CalculateArea(int a, int b)
        {
            int result = a * b;
            return result;
        }
    }
}
