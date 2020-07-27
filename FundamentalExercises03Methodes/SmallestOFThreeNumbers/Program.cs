using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SmallestOFThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            Stopwatch timer = Stopwatch.StartNew();
            int[] arrayFromString = CreatArrayFromInput(input)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer = Stopwatch.StartNew();
            int[] arrayTry = TryArray(input)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
            Console.WriteLine("Max number - {0}", arrayFromString.Max()); 
            Console.WriteLine("Min number - {0}", arrayTry.Min()); 
            
            //int min = int.MaxValue;
            //for (int i = 0; i < 3; i++)
            //{
            //    int currentNumber = int.Parse(Console.ReadLine());
            //    if (currentNumber < min)
            //    {
            //        min = currentNumber;
            //    }
            //}

            //Console.WriteLine(min);
        }

        static string CreatArrayFromInput(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();
                result.Append(input + " ");
                
            }
            
            return result.ToString();
        }

        static string TryArray(string input)
        {
            string array = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();
                array += input + " ";
            }
            
            return array;
        }
    }
}
