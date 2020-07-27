using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] field = new int[sizeOfField];
            int[] ladybugsPositions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < ladybugsPositions.Length; i++)
            {
                if (field.Length > ladybugsPositions[i] && ladybugsPositions[i] >= 0)
                {
                    field[ladybugsPositions[i]] = 1;
                }
            }
            //Console.WriteLine(string.Join(" ", field));
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladyBugFieldPosition = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                //int chosentFieldIndexValue = field[(Convert.ToInt32(command[0]))]; // field[ladyBugFieldPosition] filed[0] = 1;
                //int newFieldIndexRight = Convert.ToInt32(command[0]) + Convert.ToInt32(command[2]);
                //int newFieldIndexLeft = Convert.ToInt32(command[0]) - Convert.ToInt32(command[2]);
                if (flyLength < 0)
                {
                    if (direction == "right")
                    {
                        direction = "left";
                        flyLength = Math.Abs(flyLength);
                    }
                    else if (direction == "left")
                    {
                        direction = "right";
                        flyLength = Math.Abs(flyLength);
                    }
                }
              
                if (ladyBugFieldPosition < 0 || ladyBugFieldPosition > field.Length-1 || field[ladyBugFieldPosition] == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (field[ladyBugFieldPosition] == 1 && ladyBugFieldPosition < field.Length && ladyBugFieldPosition >= 0 && flyLength != 0)
                {
                    if (direction == "right")
                    {
                        
                        if (ladyBugFieldPosition + flyLength > field.Length - 1)
                        {
                            field[Convert.ToInt32(command[0])] = 0;
                            break;
                        }
                        else if ((ladyBugFieldPosition + flyLength) > 0 && (ladyBugFieldPosition + flyLength) < field.Length)
                        {
                            while (true)
                            {
                                if (field[(ladyBugFieldPosition + flyLength)] == 0)
                                {
                                    field[Convert.ToInt32(command[0])] = 0;
                                    field[(ladyBugFieldPosition + flyLength)] = 1;
                                    break;
                                }
                                else
                                {
                                    flyLength += flyLength;
                                }
                                if ((ladyBugFieldPosition + flyLength) > field.Length - 1)
                                {
                                    field[Convert.ToInt32(command[0])] = 0;
                                    break;
                                }   
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        
                        if ((ladyBugFieldPosition - flyLength) < 0)
                        {
                            field[Convert.ToInt32(command[0])] = 0;
                            break;
                        }
                        else if ((ladyBugFieldPosition - flyLength) >= 0 && (ladyBugFieldPosition - flyLength) < field.Length)
                        {
                            while (true)
                            {
                                if (field[(ladyBugFieldPosition - flyLength)] == 0)
                                {
                                    field[Convert.ToInt32(command[0])] = 0;
                                    field[(ladyBugFieldPosition - flyLength)] = 1;
                                    break;
                                }
                                else
                                {
                                    flyLength -= flyLength;
                                }
                                if ((ladyBugFieldPosition - flyLength) < 0)
                                {
                                    field[Convert.ToInt32(command[0])] = 0;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
