using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int ___Do___ = int.Parse(Console.ReadLine());
            for (int takoa = 2; takoa <= ___Do___; takoa++)
            {
                bool takovalie = true;
                for (int cepitel = 2; cepitel < takoa; cepitel++)
                {
                    if (takoa % cepitel == 0)
                    {
                        takovalie = false;
                        break;
                    }
                }
                if (takovalie)
                {
                    Console.WriteLine($"{takoa} -> true");
                }
                else
                {
                    Console.WriteLine($"{takoa} -> false");
                }
                
            }

        }
    }
}
