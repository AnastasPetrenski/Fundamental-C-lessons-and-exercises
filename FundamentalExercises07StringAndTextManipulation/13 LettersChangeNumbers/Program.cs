using System;
using System.Collections.Generic;
using System.Text;

namespace _13_LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            List<string> numbers = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsWhiteSpace(input[i]))
                {
                    result.Append(input[i]);
                }
                else
                {
                    if (result.Length > 0)
                    {
                        numbers.Add(result.ToString());
                        result.Clear();
                    }
                }
            }
            if (result.Length > 0)
            {
                numbers.Add(result.ToString());
            }

            double totalSum = 0;
            foreach (var number in numbers)
            {
                string current = number;
                char firstLetter = number[0];
                current = current.Remove(0, 1);
                char lastLetter = number[number.Length - 1];
                current = current.Remove(current.Length - 1, 1);
                int converted = Convert.ToInt32(current);
                double firstOperationResult = 0;
                double secondOperationResult = 0;
                if (char.IsUpper(firstLetter))
                {
                    firstOperationResult = Divided(firstLetter, converted);
                }
                else
                {
                    firstOperationResult = Multiplied(firstLetter, converted);
                }

                if (char.IsUpper(lastLetter))
                {
                    secondOperationResult = Substract(lastLetter, firstOperationResult);
                }
                else
                {
                    secondOperationResult = Add(lastLetter, firstOperationResult);
                }

                totalSum += secondOperationResult;
            }
            Console.WriteLine($"{totalSum:f2}");
        }

        public static double Add(char letter, double number)
        {
            int operand = GetLetterPosition(letter);
            double result = number + operand;
            return result;
        }

        public static double Substract(char letter, double number)
        {
            int operand = GetLetterPosition(letter);
            double result = number - operand;
            return result;
        }

        public static double Divided(char letter, int number)
        {
            int operand = GetLetterPosition(letter);
            var round = operand * 1.00;
            double result = number / round;
            return result;
        }

        public static double Multiplied(char letter, int number)
        {
            int operand = GetLetterPosition(letter);
            double result = number * operand * 1.00;
            return result;
        }

        public static int GetLetterPosition(char letter)
        {
            Dictionary<char, int> alphabets = new Dictionary<char, int>();
            alphabets.Add('A', 1);
            alphabets.Add('a', 1);
            alphabets.Add('B', 2);
            alphabets.Add('b', 2);
            alphabets.Add('C', 3);
            alphabets.Add('c', 3);
            alphabets.Add('D', 4);
            alphabets.Add('d', 4);
            alphabets.Add('E', 5);
            alphabets.Add('e', 5);
            alphabets.Add('F', 6);
            alphabets.Add('f', 6);
            alphabets.Add('G', 7);
            alphabets.Add('g', 7);
            alphabets.Add('H', 8);
            alphabets.Add('h', 8);
            alphabets.Add('I', 9);
            alphabets.Add('i', 9);
            alphabets.Add('J', 10);
            alphabets.Add('j', 10);
            alphabets.Add('K', 11);
            alphabets.Add('k', 11);
            alphabets.Add('L', 12);
            alphabets.Add('l', 12);
            alphabets.Add('M', 13);
            alphabets.Add('m', 13);
            alphabets.Add('N', 14);
            alphabets.Add('n', 14);
            alphabets.Add('O', 15);
            alphabets.Add('o', 15);
            alphabets.Add('P', 16);
            alphabets.Add('p', 16);
            alphabets.Add('Q', 17);
            alphabets.Add('q', 17);
            alphabets.Add('R', 18);
            alphabets.Add('r', 18);
            alphabets.Add('S', 19);
            alphabets.Add('s', 19);
            alphabets.Add('T', 20);
            alphabets.Add('t', 20);
            alphabets.Add('U', 21);
            alphabets.Add('u', 21);
            alphabets.Add('V', 22);
            alphabets.Add('v', 22);
            alphabets.Add('W', 23);
            alphabets.Add('w', 23);
            alphabets.Add('X', 24);
            alphabets.Add('x', 24);
            alphabets.Add('Y', 25);
            alphabets.Add('y', 25);
            alphabets.Add('Z', 26);
            alphabets.Add('z', 26);
            return alphabets[letter];
        }
    }
}
