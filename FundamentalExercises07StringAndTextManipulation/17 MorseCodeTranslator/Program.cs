using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17_MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> code = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Decoder(code);
        }

        public static void Decoder(List<string> code)
        {
            StringBuilder expression = new StringBuilder();
            for (int i = 0; i < code.Count; i++)
            {
                expression.Append(GetLetter(code[i]));
            }
            Console.WriteLine(expression);
        }

        public static char GetLetter(string symbol)
        {
            char letter = '0';
            Dictionary<string, char> morseAlphabetics = new Dictionary<string, char>();
            morseAlphabetics.Add(".-", 'A');
            morseAlphabetics.Add("-...", 'B');
            morseAlphabetics.Add("-.-.", 'C');
            morseAlphabetics.Add("-..", 'D');
            morseAlphabetics.Add(".", 'E');
            morseAlphabetics.Add("..-.", 'F');
            morseAlphabetics.Add("--.", 'G');
            morseAlphabetics.Add("....", 'H');
            morseAlphabetics.Add("..", 'I');
            morseAlphabetics.Add(".---", 'J');
            morseAlphabetics.Add("-.-", 'K');
            morseAlphabetics.Add(".-..", 'L');
            morseAlphabetics.Add("--", 'M');
            morseAlphabetics.Add("-.", 'N');
            morseAlphabetics.Add("---", 'O');
            morseAlphabetics.Add(".--.", 'P');
            morseAlphabetics.Add("--.-", 'Q');
            morseAlphabetics.Add(".-.", 'R');
            morseAlphabetics.Add("...", 'S');
            morseAlphabetics.Add("-", 'T');
            morseAlphabetics.Add("..-", 'U');
            morseAlphabetics.Add("...-", 'V');
            morseAlphabetics.Add(".--", 'W');
            morseAlphabetics.Add("-..-", 'X');
            morseAlphabetics.Add("-.--", 'Y');
            morseAlphabetics.Add("--..", 'Z');
            morseAlphabetics.Add("|", ' ');
            if (!morseAlphabetics.ContainsKey(symbol))
            {
                return letter = ' ';
            }
            return morseAlphabetics[symbol];
        }
    }
}
