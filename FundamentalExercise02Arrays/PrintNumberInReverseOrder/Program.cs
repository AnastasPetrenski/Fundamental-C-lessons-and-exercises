using System;

namespace PrintNumberInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arrr = new string[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                arrr[i] = input;
            }

            Array.Reverse(arrr);

            foreach (var value in arrr)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
