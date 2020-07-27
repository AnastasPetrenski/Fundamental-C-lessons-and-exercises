using System;
using System.Linq;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            //read inputed lines
            long linesInput = long.Parse(Console.ReadLine());
            double bigger = 0;
            string[] separators = {" ", ","};
            //create new array and compare which digit of the array is bigger
            for (int i = 0; i < linesInput; i++)
            {
                double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
                if (arr[0] > arr[1])
                {
                    bigger = Math.Abs(arr[0]);
                }
                else
                {
                    bigger = Math.Abs(arr[1]);
                }
                //convert the bigger number to string
                string numberForCalc = bigger.ToString();
                
                //convert number's elements to an array
                string stringForArr = ConvertString(numberForCalc);

                //convert string to array of string elements and calculate the sum of its elements
                long sum = SplitStringToArrayAndCalcResult(stringForArr);
                Console.WriteLine($"Try foreach {sum}");

                long sum1 = 0;
                string[] arrrr = stringForArr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int x = 0; x < arrrr.Length; x++)
                {
                    sum1 += int.Parse(arrrr[x]);
                }
                Console.WriteLine(sum1);
            }
        }

        static string ConvertString(string numberForCalc) // <-- input parameter string as number"234234"
        {
            string stringForArr = string.Empty; // new variable to be returned as argument
            for (int j = 0; j < numberForCalc.Length; j++)
            {
                stringForArr += numberForCalc[j].ToString() + " ";
            }
            return stringForArr; // final result, input parameter converted to new variable result
        }

        static int SplitStringToArrayAndCalcResult(string stringForArr)
        {
            string[] separators = { " ", "," };
            int sum = 0;
            int[] tryArr = stringForArr.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var value in tryArr)
            {
                sum += value;
            }
            return sum;
        }
    }
}
