using System;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
 
            int[] arr3;
            string[] arr4;
            for (int k = 0; k < n; k++)
            {

                string input = Console.ReadLine();
                arr3 = new int[input.Length];
                arr4 = new string[input.Length];
                for (int x = 0; x < input.Length; x++)
                {
                    if (x % 2 == 0)
                    {
                        arr4[x] = input[x].ToString();
                        arr3[x] = input[x];
                    }
                    else
                    {
                        arr3[x] = input[x];
                        arr4[x] = input[x].ToString();
                    }
                }
                foreach (var item in arr3)
                {
                    Console.Write((char)item + " ");
                }
                Console.WriteLine();
                Console.WriteLine(string.Join("", arr3));
                Console.WriteLine(string.Join("", arr4));
            }
        }
    }
}
