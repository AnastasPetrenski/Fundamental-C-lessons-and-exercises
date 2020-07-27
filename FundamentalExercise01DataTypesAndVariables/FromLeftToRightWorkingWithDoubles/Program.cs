using System;
using System.Linq;

namespace FromLeftToRightWorkingWithDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            //read inputed lines
            long linesInput = long.Parse(Console.ReadLine());
            double bigger = 0;
            string[] separators = { " ", "," };
            //create new array and compare which digit of the array is bigger
            for (int i = 0; i < linesInput; i++)
            {
                double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
                double sum = 0;
                if (arr[0] > arr[1])
                {
                    bigger = Math.Abs(arr[0]);
                    while (bigger > 0)
                    {
                        sum += (bigger % 10);
                        bigger /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    bigger = Math.Abs(arr[1]);
                    while (bigger > 0)
                    {
                        sum += (bigger % 10);
                        bigger /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
