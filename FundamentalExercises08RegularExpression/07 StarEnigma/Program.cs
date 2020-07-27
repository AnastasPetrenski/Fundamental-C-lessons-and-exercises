using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _07_StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternKeyReducer = new Regex(@"[s,S,t,T,a,A,r,R]");
            // - wrong expression: @(?<planet>[A-z]+).*?:(\d+).*?!(?<action>[A,D])!.*?->(\d+)
            //Regex patternDecrypting = new Regex(@"@(?<planet>[a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!(?<action>[AD])![^@\-!:>]*->[0-9]+");
            Regex patternDecrypting = new Regex(@"@(?<planet>[A-z]+)[^@\-!:>]*?:(\d+)[^@\-!:>]*?!(?<action>[A,D])![^@\-!:>]*?->(\d+)");
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();
            for (int i = 0; i < n; i++)
            {
                //input - STCDoghudd4=63333$D$0A53333
                string input = Console.ReadLine();
                var result = patternKeyReducer.Matches(input);
                int keyReducer = result.Count;
                StringBuilder decryptedMessage = new StringBuilder();
                for (int j = 0; j < input.Length; j++)
                {
                    int currentLetter = input[j] - keyReducer;
                    decryptedMessage.Append((char)currentLetter);
                }
                //decrypted message - PQ@Alderaa1:30000!A!->20000
                var message = patternDecrypting.Matches(decryptedMessage.ToString());
                if (patternDecrypting.IsMatch(decryptedMessage.ToString()))
                {
                    foreach (Match item in message)
                    {
                        if (item.Groups["action"].Value == "A")
                        {
                            attackedPlanet.Add(item.Groups["planet"].Value);
                        }
                        else if (item.Groups["action"].Value == "D")
                        {
                            destroyedPlanet.Add(item.Groups["planet"].Value);
                        }
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
            if (attackedPlanet.Count > 0)
            {
                attackedPlanet.Sort();
                Console.Write("-> ");
                Console.WriteLine(string.Join(Environment.NewLine + "-> ", attackedPlanet));
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");
            if (destroyedPlanet.Count > 0)
            {
                destroyedPlanet.Sort();
                Console.Write("-> ");
                Console.WriteLine(string.Join(Environment.NewLine + "-> ", destroyedPlanet));
            }
        }
    }
}
