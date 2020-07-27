using System;
using System.Text.RegularExpressions;

namespace _02_MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(\+359)(( )|(-))2\2\d{3}\2\d{4}\b");
            string phones = Console.ReadLine();
            MatchCollection phonesBook = pattern.Matches(phones);
            Console.Write(string.Join(", ", phonesBook));
        }
    }
}
