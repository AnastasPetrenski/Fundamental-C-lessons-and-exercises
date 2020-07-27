using System;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberToString = number.ToString();
            int result = 0;
            for (int i = 0; i < numberToString.Length; i++)
            {
                //char singleNum = (char)numberToString[i];                   //first way
                //int toInt32 = int.Parse(singleNum.ToString());

                //int toInt32 = int.Parse(numberToString[i].ToString());      //second way

                int toInt33 = Convert.ToInt32(numberToString[i].ToString());  //third way
                result += toInt33;

                //result += numberToString[i] - '0';                            //fourth way
            }
            Console.WriteLine(result);
        }
    }
}
