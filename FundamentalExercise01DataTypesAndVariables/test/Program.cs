using System;

namespace ConvertStringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordParse = word;
            int sum = 0;
            char singleLetter = 'a';
            string capture = string.Empty;
            string newNumber = "";
            for (int i = 0; i < wordParse.Length; i++) // .Length of the word, count the letters holded in the word
            {
                singleLetter = wordParse[i]; // print letter, [index] the current position of the letter inside the word 
                int currentLetter = wordParse[i]; // print number value of the letter from ASCTable, 
                int n = Convert.ToInt32(wordParse[i]);
                //Console.WriteLine(n + "???");
                sum += currentLetter;
                Console.WriteLine($"[{i}] : {singleLetter} = {currentLetter}");
                capture = "" + currentLetter;
                newNumber += capture;
            }
            Console.WriteLine(sum);
            Console.WriteLine($"{newNumber} it's string");
            int newNumberCreatedToInt = int.Parse(newNumber);

            int evenSum = 0;
            for (int i = 0; i < newNumber.Length; i++)
            {
                string toStringNumberCreated = newNumberCreatedToInt.ToString();
                Console.Write(toStringNumberCreated[i] + " ");// digits
                for (int j = 0; j < toStringNumberCreated.Length; j++)
                {
                    int currentDigit = int.Parse(toStringNumberCreated[j].ToString());
                    if (toStringNumberCreated[j] % 2 == 0)
                    {
                        //Console.WriteLine($"Even 'j' ={toStringNumberCreated[j]}");
                        evenSum += currentDigit;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            Console.Write("<-- string integers");
            Console.WriteLine();
            Console.WriteLine($"{evenSum} <-- sum of evevn digits");
        }
    }
}
