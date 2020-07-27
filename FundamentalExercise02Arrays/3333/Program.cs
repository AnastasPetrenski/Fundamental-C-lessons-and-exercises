using System;
using System.Linq;

namespace _3333
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] template = { 1, 3, 5 };
            int[] arr = new int[6];

            

            for (int x = 0; x < template.Length; x++)
            {
                if (numbers.Contains(template[x]))
                {
                    arr[template[x]] = 1;
                }
            }
            Console.WriteLine(string.Join(" ", arr));

            
            int a = 0;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);
            int fibNum = 0;
            for (int i = 0; i < 10; i++)
            {
                fibNum = a + b;
                a = b;
                b = fibNum;
                Console.WriteLine(fibNum);
            }
        }
    }
}
