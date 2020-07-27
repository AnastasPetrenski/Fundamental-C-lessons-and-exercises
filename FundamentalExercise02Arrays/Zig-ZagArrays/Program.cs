using System;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr1 = new int[n];
            var arr2 = new int[n];
            for (int i = 1; i <= n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                if (i % 2 != 0)
                {
                    arr1[i - 1] = Convert.ToInt32(temp[0]);
                    arr2[i - 1] = Convert.ToInt32(temp[1]);
                }
                else
                {
                    arr1[i - 1] = Convert.ToInt32(temp[1]);
                    arr2[i - 1] = Convert.ToInt32(temp[0]);
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

            int[] arr3 = new int[n];
            var arr4 = new string[n];
            for (int k = 0; k < n; k++)
            {
                string input = Console.ReadLine();
                for (int x = 0; x < input.Length; x++)
                {
                    if (k % 2 == 0)
                    {
                        arr4[x] = input[2].ToString();
                        arr3[x] = input[0];
                    }
                    else
                    {
                        arr3[x] = input[0];
                        arr4[x] = input[2].ToString();
                    }
                }

            }
            Console.WriteLine(string.Join(" ", arr3));
            Console.WriteLine(string.Join(" ", arr4));
        }
    }
}
