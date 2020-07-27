using System;
using System.Text;

namespace _01_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                //string reversed = string.Empty;
                StringBuilder reversed = new StringBuilder();
                for (int i = command.Length - 1; i >= 0 ; i--)
                {
                    reversed.Append(command[i]);
                }
                Console.WriteLine($"{command} = {reversed}");
            }
        }
    }
}
