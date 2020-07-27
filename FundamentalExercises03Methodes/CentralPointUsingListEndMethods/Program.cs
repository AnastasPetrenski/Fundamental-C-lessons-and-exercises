using System;
using System.Collections.Generic;
using System.Linq;

namespace CentralPointUsingListEndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int>();
            List<int> y = new List<int>();
            List<int> all = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    x.Add(input);
                }
                else if (i % 2 == 0)
                {
                    y.Add(input);
                }
                all.Add(input);
            }

            int minAll = Math.Abs(all.Min(all => all));
            var indexMin = all.Where(x => x == minAll);

            int minX = Math.Abs(x.Min(x => x));
            int minY = Math.Abs(y.Min(y => y));

        }
    }
}
