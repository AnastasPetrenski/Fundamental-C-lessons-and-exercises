using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string input)
        {
            if (input.Length == 1 || input.Length == 2 || input.Length == 0)
            {
                Console.Write(input);
            }
            else
            {
                if (input.Length % 2 == 0)
                {
                    for (int i = input.Length / 2 - 1; i <= input.Length / 2; i++)
                    {
                        Console.Write(input[i]);
                    }
                }
                else
                {
                    for (int i = input.Length / 2; i <= input.Length / 2; i++)
                    {
                        Console.Write(input[i]);
                    }
                }
            }
        }
    }
}
