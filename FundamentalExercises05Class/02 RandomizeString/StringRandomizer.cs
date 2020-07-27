using System;
using System.Collections.Generic;
using System.Text;

namespace _02_RandomizeString
{
    class StringRandomizer
    {
        public string[] Words;

        public void Randomizer()
        {
            Random instance = new Random();
            for (int i = 0; i < Words.Length; i++)
            {
                int randomPosition = instance.Next(0, this.Words.Length);
                string temp = this.Words[i];
                this.Words[i] = this.Words[randomPosition];
                this.Words[randomPosition] = temp;
            }
        }

        public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.Words));
        }
    }
}
