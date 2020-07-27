using System;

namespace LowerCaseOrUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int m = input;
            if (m >= 65 && m <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (m >= 97 && m <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
