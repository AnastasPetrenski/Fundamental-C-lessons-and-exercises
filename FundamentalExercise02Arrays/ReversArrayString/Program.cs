using System;

namespace ReversArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Array.Reverse(input);
            foreach (var item in input)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
