using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            
            //int sum1 = 0;
            //input example 22 
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                string number = i.ToString();
                for (int j = 0; j < number.Length; j++)
                {
                    //int m = number[i];
                    //Console.WriteLine((char)m); m = char '2', value = 50;
                    //sum1 += m;
                    int singleDigit = number[j] - '0';
                    sum += singleDigit;
                }
                if (sum == 0)
                {
                    continue;
                }
                else if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
            //Console.WriteLine(sum1); = get ASCII value of the variable 2+2 = 50+50 = 100
        }
    }
}
