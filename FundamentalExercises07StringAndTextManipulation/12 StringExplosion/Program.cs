using System;
using System.Linq;

namespace _12_StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().ToList();
            for (int i = 0; i < input.Count - 1; i++)
            {
                int power = 0;
                int counter = 0;
                if (input[i] == '>')
                {
                    power = input[i + 1] - '0';
                    if (power == 0)
                    {
                        input.RemoveAt(i + 1);
                        continue;
                    }
                    for (int j = i + 1; j <= input.Count - 1; j++)
                    {
                        if (j <= input.Count - 1 && input[i + 1].ToString() != ">")
                        {
                            input.RemoveAt(i + 1);
                            j--;
                            counter++;
                            if (counter == power)
                            {
                                break;
                            }
                        }
                        else if (j <= input.Count - 1 && input[i + 1].ToString() == ">")
                        {
                            int addPower = input[i + 2] - '0';
                            power += addPower;
                            i++;
                        }

                    }
                }
            }
            Console.Write(string.Join("", input));
        }
    }
}
