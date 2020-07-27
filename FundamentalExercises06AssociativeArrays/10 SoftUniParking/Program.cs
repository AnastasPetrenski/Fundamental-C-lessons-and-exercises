using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "register" && !register.ContainsKey(command[1]))
                {
                    register.Add(command[1], command[2]);
                    Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                }
                else if (command[0] == "register" && register.ContainsKey(command[1]))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                }
                else if (command[0] == "unregister" && register.ContainsKey(command[1]))
                {
                    register.Remove(command[1]);
                    Console.WriteLine($"{command[1]} unregistered successfully");
                }
                else if (command[0] == "unregister" && !register.ContainsKey(command[1]))
                {
                    Console.WriteLine($"ERROR: user {command[1]} not found");
                }
            }

            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
