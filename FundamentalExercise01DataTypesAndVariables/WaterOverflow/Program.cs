using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int counterLitersPoured = 0;
            for (int i = 0; i < n; i++)
            {
                int inputLiters = int.Parse(Console.ReadLine());
                if (inputLiters <= capacity)
                {
                    capacity -= inputLiters;
                    counterLitersPoured += inputLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(counterLitersPoured);
        }
    }
}
