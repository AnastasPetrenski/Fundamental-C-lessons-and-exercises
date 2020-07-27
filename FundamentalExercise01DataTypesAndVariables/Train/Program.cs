using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                int input = int.Parse(Console.ReadLine());
                people[i] = input;
            }
            int sum = 0;
            foreach (var item in people)
            {
                sum += item;
            }
            Console.WriteLine(String.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
