using System;
using System.Numerics;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isInteger = false, isDouble = false, isBoolean = false, isChar = false, isString = false;
                BigInteger n = 0;
                double x = 0;
                char a = 'a';
                string f = "false";
                string t = "true";
                try
                {
                    n = BigInteger.Parse(input);
                    isInteger = true;
                }
                catch (FormatException e)
                {
                    try
                    {
                        x = double.Parse(input);
                        isDouble = true;
                    }
                    catch (Exception)
                    {
                        try
                        {
                            a = char.Parse(input);
                            isChar = true;
                        }
                        catch (Exception)
                        {
                            try
                            {
                                if (t == input || f == input)
                                {
                                    isBoolean = true;
                                }
                                else
                                {
                                    isString = true;
                                }
                            }
                            catch (Exception)
                            {
                               
                            }
                        }
                    }
                }
                if (isString)
                {
                    Console.WriteLine($"{input} is string type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                input = Console.ReadLine();
            }

        }
        //static string Comparison(string input) 
        //{
        //    string n = "false";
        //    string m = "true";
        //    string result = string.Empty;
        //    if (n == input)
        //    {
        //        result = "false";
        //    }
        //    else if (m == input)
        //    {
        //        result = "true";
        //    }
        //    return result;
        //}
    }
}
