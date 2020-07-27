using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int tottalYield = 0;
            int days = 0;
            while (startYield >= 100)
            {
                days++;
                tottalYield += startYield;
                startYield -= 10;
                tottalYield -= 26;
                if (startYield < 100)
                {
                    tottalYield -= 26;
                }
            }
            Console.WriteLine(days);
            Console.WriteLine(tottalYield);
        }
    }
}
