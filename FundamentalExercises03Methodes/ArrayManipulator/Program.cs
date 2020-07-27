using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] manipulatedArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command.Contains<string>("exchange"))
                {
                    ExchangeArray(command[1], manipulatedArray);
                }
                else if (command.Contains<string>("max"))
                {
                    GetIndexOfMaxValueNumber(command[1], manipulatedArray);
                }
                else if (command.Contains<string>("min"))
                {
                    GetIndexOfMinValueNumber(command[1], manipulatedArray);
                }
                else if (command.Contains<string>("first"))
                {
                    GetFirstNumbers(Convert.ToInt32(command[1]), command[2], manipulatedArray);
                }
                else if (command.Contains<string>("last"))
                {
                    GetLastNumbers(Convert.ToInt32(command[1]), command[2], manipulatedArray);
                }

            }
            Console.Write("[");
            Console.Write(string.Join(", ", manipulatedArray));
            Console.WriteLine("]");
        }

        static void ExchangeArray(string index, int[] manipulatedArray)
        {
            if (Convert.ToInt32(index) > manipulatedArray.Length - 1 || Convert.ToInt32(index) < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for (int x = 0; x <= Convert.ToInt32(index); x++)
                {
                    int temp = manipulatedArray[0];
                    for (int i = 0; i < manipulatedArray.Length - 1; i++)
                    {
                        manipulatedArray[i] = manipulatedArray[i + 1];
                    }
                    manipulatedArray[manipulatedArray.Length - 1] = temp;
                }
            }
        }

        static void GetIndexOfMaxValueNumber(string numberType, int[] manipulatedArray)
        {
            int index = 0;
            int max = int.MinValue;
            if (numberType == "even")
            {
                for (int i = 0; i < manipulatedArray.Length; i++)
                {
                    if (manipulatedArray[i] % 2 == 0 && manipulatedArray[i] >= max)
                    {
                        max = manipulatedArray[i];
                        index = i;
                    }
                }
                //max = manipulatedArray.Where(x => x % 2 == 0).Max();
                //index = Array.IndexOf(manipulatedArray, max);
            }
            else if (numberType == "odd")
            {
                for (int i = 0; i < manipulatedArray.Length; i++)
                {
                    if (manipulatedArray[i] % 2 != 0 && manipulatedArray[i] >= max)
                    {
                        max = manipulatedArray[i];
                        index = i;
                    }
                }
                //max = manipulatedArray.Where(x => x % 2 != 0).Max();
                //index = Array.IndexOf(manipulatedArray, max);
            }

            if (max == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{index}");
            }
        }

        static void GetIndexOfMinValueNumber(string numberType, int[] manipulatedArray)
        {
            int index = 0;
            int min = int.MaxValue;
            if (numberType == "even")
            {
                for (int i = 0; i < manipulatedArray.Length; i++)
                {
                    if (manipulatedArray[i] % 2 == 0 && manipulatedArray[i] <= min)
                    {
                        min = manipulatedArray[i];
                        index = i;
                    }
                }
            }
            else if (numberType == "odd")
            {
                for (int i = 0; i < manipulatedArray.Length; i++)
                {
                    if (manipulatedArray[i] % 2 != 0 && manipulatedArray[i] <= min)
                    {
                        min = manipulatedArray[i];
                        index = i;
                    }
                }
            }

            if (min == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{index}");
            }
        }

        static void GetFirstNumbers(int repeatTimes, string numberType, int[] manipulatedArray)
        {
            if (repeatTimes > manipulatedArray.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> firstArr = new List<int>();
                int count = 0;
                if (numberType == "even")
                {
                    for (int i = 0; i < manipulatedArray.Length; i++)
                    {
                        if (manipulatedArray[i] % 2 == 0)
                        {
                            firstArr.Add(manipulatedArray[i]);
                            count++;
                        }

                        if (count == repeatTimes)
                        {
                            break;
                        }
                    }
                }
                else if (numberType == "odd")
                {
                    for (int i = 0; i < manipulatedArray.Length; i++)
                    {
                        if (manipulatedArray[i] % 2 != 0)
                        {
                            firstArr.Add(manipulatedArray[i]);
                            count++;
                        }

                        if (count == repeatTimes)
                        {
                            break;
                        }
                    }
                }
                Console.Write("[");
                Console.Write(string.Join(", ", firstArr));
                Console.WriteLine("]");
            }
            
        }

        static void GetLastNumbers(int repeatTimes, string numberType, int[] manipulatedArray)
        {
            if (repeatTimes > manipulatedArray.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> lastArr = new List<int>();
                int count = 0;
                if (numberType == "even")
                {
                    for (int i = manipulatedArray.Length - 1; i >= 0; i--)
                    {
                        if (manipulatedArray[i] % 2 == 0)
                        {
                            lastArr.Add(manipulatedArray[i]);
                            count++;
                        }

                        if (count == repeatTimes)
                        {
                            break;
                        }
                    }
                }
                else if (numberType == "odd")
                {
                    for (int i = manipulatedArray.Length - 1; i >= 0; i--)
                    {
                        if (manipulatedArray[i] % 2 != 0)
                        {
                            lastArr.Add(manipulatedArray[i]);
                            count++;
                        }

                        if (count == repeatTimes)
                        {
                            break;
                        }
                    }
                }
                lastArr.Reverse();
                Console.WriteLine("[" + string.Join(", ", lastArr) + "]");
            }
        }
    }
}