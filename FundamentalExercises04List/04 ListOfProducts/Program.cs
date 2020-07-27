using System;

namespace _04_ListOfProductsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = CreatStringArray(length);
            PrintArrayAscendingOrder(names, length);
        }

        static string[] CreatStringArray(int length)
        {
            string[] names = new string[length];
            string name = string.Empty;
            for (int i = 0; i < length; i++)
            {
                name = Console.ReadLine();
                names[i] = name;
            }
            Array.Sort(names);
            return names;
        }

        static void PrintArrayAscendingOrder(string[] names, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i+1}.{names[i]}");
            }   
        }
    }
}
