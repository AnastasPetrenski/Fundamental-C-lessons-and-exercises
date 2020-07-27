using System;

namespace GreaterOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetBigger(first, second));
            }
        }

        static int GetBigger(int a, int b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetBigger(char a, char b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetBigger(string a, string b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


    }
}
