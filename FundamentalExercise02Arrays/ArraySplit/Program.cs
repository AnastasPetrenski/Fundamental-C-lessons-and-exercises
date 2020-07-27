using System;

namespace ArraySplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] numbersAsString = input.Split(new char[] {' ', ','});
            int[] numbers = new int[numbersAsString.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsString[i]);
            }
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine($"index array position [{x}] ({numbersAsString[x] + 5})");
            }
            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.WriteLine(item + 5);
            }
        }
    }
}
