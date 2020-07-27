using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());
            bool balanced = false;
            bool openBracketFound = false;
            int totalBracket = 0;
            int balancedBracket = 0;
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(" || input == ")")
                {
                    totalBracket++;
                }
                if (input == "(" && openBracketFound == false)
                {
                    openBracketFound = true;
                    if (balanced == true)
                    {
                        balanced = false;
                    }
                }

                if (input == ")" && openBracketFound == true)
                {
                    openBracketFound = false;
                    balanced = true;
                    balancedBracket += 2;
                }
                
            }
            if (balanced && (totalBracket == balancedBracket))
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
