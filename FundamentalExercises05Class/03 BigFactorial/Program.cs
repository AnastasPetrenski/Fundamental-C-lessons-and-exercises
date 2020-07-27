using System;
using System.Numerics;

namespace _03_BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Initialize the new instance of the class - new object
            Factorial num = new Factorial();
            //2. Read the input
            num.n = int.Parse(Console.ReadLine());
            //3. Calculate the factorial
            num.CalculateFactorial(num.n);
        }
    }

    //1. Create class
    public class Factorial
    {
        //2.Properties of the objects in the class
        public BigInteger n { get; set; }

        //3. Method of the class
        public void CalculateFactorial(BigInteger n)
        {
            BigInteger result = 1;
            for (BigInteger i = n; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

        //public void 
    }
}
