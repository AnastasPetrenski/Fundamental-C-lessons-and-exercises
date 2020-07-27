using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_CarsRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double firstCar = 0.0;
            double secondCar = 0.0;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                firstCar += numbers[i];
                if (numbers[i] == 0)
                {
                    firstCar *= 0.8;
                }
            }

            for (int j = numbers.Count - 1; j > numbers.Count / 2; j--)
            {
                secondCar += numbers[j];
                if (numbers[j] == 0)
                {
                    secondCar *= 0.8;
                }
            }

            if (firstCar < secondCar)
            {
                Console.WriteLine($"The winner is left with total time: {firstCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondCar}");
            }
        }
    }
}
