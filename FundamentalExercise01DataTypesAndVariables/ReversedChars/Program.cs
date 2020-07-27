using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string messege = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                messege += input + " ";
            }

            string[] arr = messege.Split();
            for (int j = 0; j < arr.Length/2; j++)
            {
                string temp = arr[j];
                arr[j] = arr[arr.Length -1 -j];
                arr[arr.Length - 1 - j] = temp;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
