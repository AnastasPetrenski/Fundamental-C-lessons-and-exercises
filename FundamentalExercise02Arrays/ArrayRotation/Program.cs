using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numRotation = int.Parse(Console.ReadLine());
            for (int x = 0; x < numRotation % arr.Length; x++)
            {
                int temp = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
