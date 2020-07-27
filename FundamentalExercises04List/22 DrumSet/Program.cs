using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSetInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> damagedSet = new List<int>();
            damagedSet.AddRange(drumSetInput);
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < damagedSet.Count; i++)
                {
                    damagedSet[i] -= hitPower; 
                }

                List<int> brokenDrums = damagedSet.FindAll(x => x <= 0);

                if (brokenDrums.Count > 0)
                {
                    int index = 0;
                    for (int i = 0; i < brokenDrums.Count; i++)
                    {
                        index = damagedSet.IndexOf(brokenDrums[i]);
                        int value = drumSetInput[index];
                        if ((value * 3) <= savings)
                        {
                            savings -= value * 3;
                            damagedSet[index] = value;
                        }
                        else
                        {
                            damagedSet[index] = -1000;
                        }
                    }
                }
            }
            damagedSet.RemoveAll(x => x <= 0);
            Console.WriteLine(string.Join(" ", damagedSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
