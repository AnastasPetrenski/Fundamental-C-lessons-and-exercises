using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Train
            //You will receive a list of wagons(integers) on the first line. Every integer represents the number of passengers that are currently in each of the wagons. On the next line, you will get the max capacity of each wagon(a single integer). Until you receive "end" you will be given two types of input:
            //•	Add { passengers} – add a wagon to the end with the given number of passengers.
            //•	{ passengers} - find an existing wagon to fit every passenger, starting from the first wagon.
            //At the end print the final state of the train(each of the wagons, separated by a space).

            List<int> wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> currCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (currCommand.Contains("Add"))
                {
                    wagons.Add(int.Parse(currCommand[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity - wagons[i] >= int.Parse(currCommand[0]))
                        {
                            wagons[i] += int.Parse(currCommand[0]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
