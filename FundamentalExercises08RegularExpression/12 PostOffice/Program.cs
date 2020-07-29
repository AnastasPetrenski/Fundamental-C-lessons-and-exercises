using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _12_PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            //sdsGGasAOTPWEEEdas$AOTP$|a65:1.2s65:03d79:01ds84:02! -80:07++ABs90:1.1|adsaArmyd Gara So La Arm Armyw21 Argo O daOfa Or Ti Sar saTheww The Parahaos
            Regex capitalLetters = new Regex(@"([\#\$\%\*\&])([A-Z]+)(\1)");
            Regex findNumber = new Regex(@"(\d+):(\d\d)");
            List<string> parts = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            var startLetters = capitalLetters.Matches(parts[0]);
            var numbersPairs = findNumber.Matches(parts[1]);
            StringBuilder letters = new StringBuilder();
            foreach (Match item in startLetters)
            {
                letters.Append(item.Groups[2].Value);
            }

            Dictionary<char, int> lettersLen = new Dictionary<char, int>();
            for (int i = 0; i < letters.Length; i++)
            {
                int numberOfLetter = letters[i];
                if (parts[1].Contains(numberOfLetter.ToString()))
                {
                    int letterLen = 0;
                    foreach (Match pair in numbersPairs.Where(x => x.Value.Contains(numberOfLetter.ToString())))
                    {
                        if (!lettersLen.ContainsKey(letters[i]))
                        {
                            letterLen = int.Parse(pair.Groups[2].Value);
                            lettersLen.Add(letters[i], letterLen + 1);
                            continue;
                        }
                    }
                }
            }

            List<string> words = parts[2].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var letter in lettersLen)
            {
                char firstLetter = letter.Key;
                int letterLen = lettersLen[letter.Key];
                foreach (var word in words)
                {
                    if (word.StartsWith(firstLetter) && word.Length == letterLen)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

        }
    }
}
