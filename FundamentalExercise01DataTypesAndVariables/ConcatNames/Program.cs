using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            for (int j = 0; j < arr.Length/2; j++)
            {
                string temp = arr[1];
                arr[1] = arr[2];
                arr[2] = temp;
            }
            foreach (var value in arr)
            {
                Console.Write(value);
            }
        }
    }
}
