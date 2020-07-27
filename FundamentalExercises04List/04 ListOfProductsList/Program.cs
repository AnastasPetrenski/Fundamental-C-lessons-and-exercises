using System;
using System.Collections.Generic;

namespace _04_ListOfProductsList
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = CreatList(length);
            PrintListElementsAscendingOrder(names, length);
        }

        static List<string> CreatList(int length)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < length; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            names.Sort();
            return names;
        }

        static void PrintListElementsAscendingOrder(List<string> names, int length)
        {
            for (int j = 0; j < length; j++)
            {
                Console.WriteLine($"{j+1}.{names[j]}");
            }
        }
    }
}
