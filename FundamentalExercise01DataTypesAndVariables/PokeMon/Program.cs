using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerPokeMon = int.Parse(Console.ReadLine());   
            int distance = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int counter = 0;
            int difference = powerPokeMon;

            while (difference >= distance)
            {
                difference -= distance;
                counter++;
                double halfPower = powerPokeMon * 1.00 / 2;
                if (halfPower == difference && index > 0) //we can not divide by zero '0'
                {
                    difference = difference / index;
                }
            }
            Console.WriteLine(difference);
            Console.WriteLine(counter);
        }
    }
}
