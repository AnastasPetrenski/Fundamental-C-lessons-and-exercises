using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = String.Empty;
            double radius = 0;
            int height = 0;
            double volume = 0;
            string theBiggestKeg = String.Empty;
            double theBiggest = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > theBiggest)
                {
                    theBiggest = volume;
                    theBiggestKeg = model;
                }
            }
            Console.WriteLine(theBiggestKeg);
        }
    }
}
