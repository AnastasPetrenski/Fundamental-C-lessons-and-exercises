using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16_TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //key input - 1 2 1 3
            List<int> keys = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = string.Empty;
            //expresion input - ikegfp'jpne)bv=41P83X@
            while ((command = Console.ReadLine()) != "find")
            {
                int count = 0;
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < command.Length; i++)
                {
                    int currentLetter = command[i];
                    currentLetter -= keys[count];
                    result.Append((char)currentLetter);
                    count++;
                    if (count == keys.Count)
                    {
                        count = 0;
                    }
                }
                //result - hidden&gold&at<10N70W>
                int startIndexType = result.ToString().IndexOf('&');
                StringBuilder type = new StringBuilder();
                if (startIndexType != -1)
                {
                    while (char.IsLetter(result.ToString()[startIndexType + 1]))
                    {
                        type.Append(result.ToString()[startIndexType + 1]);
                        startIndexType++;
                    }

                    int startIndexLocation = result.ToString().IndexOf('<');
                    int endIndexLocation = result.ToString().IndexOf('>');
                    int length = endIndexLocation - startIndexLocation;
                    string coordinates = result.ToString().Substring(startIndexLocation + 1, length - 1);

                    Console.WriteLine($"Found {type} at {coordinates}");
                }

            }
        }
    }
}
