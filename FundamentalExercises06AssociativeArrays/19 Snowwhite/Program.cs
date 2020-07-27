using System;
using System.Collections.Generic;
using System.Linq;

namespace _19_Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                List<string> input = command.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = input[0];
                string color = input[1];
                long physics = long.Parse(input[2]);
                if (dwarfs.Any(x => x.Name == name))
                {
                    bool addInput = true;
                    foreach (var dwarf in dwarfs)
                    {
                        if (dwarf.Name == name && dwarf.Color == color && dwarf.Physics < physics)
                        {
                            dwarf.Physics = physics;
                            addInput = false;
                            break;
                        }
                        else if (dwarf.Name == name && dwarf.Color == color && dwarf.Physics >= physics)
                        {
                            addInput = false;
                            break;
                        }
                    }
                    if (addInput)
                    {
                        dwarfs.Add(Dwarf.AddDwarf(input));
                    }
                }
                else
                {
                    dwarfs.Add(Dwarf.AddDwarf(input));
                }
            }

            //Sort and Print - Name - Solor - Physics
            Dictionary<string, List<Dwarf>> colorCounter = new Dictionary<string, List<Dwarf>>();
            foreach (var dwarf in dwarfs)
            {
                if (!colorCounter.ContainsKey(dwarf.Color))
                {
                    colorCounter.Add(dwarf.Color, new List<Dwarf>());
                    colorCounter[dwarf.Color].Add(dwarf);
                }
                else
                {
                    colorCounter[dwarf.Color].Add(dwarf);
                }
            }

            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Physics).ThenByDescending(a => colorCounter[a.Color].Count))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public long Physics { get; set; }

        public Dwarf()
        {

        }

        public static Dwarf AddDwarf(List<string> input)
        {
            Dwarf dwarf = new Dwarf();
            dwarf.Name = input[0];
            dwarf.Color = input[1];
            dwarf.Physics = long.Parse(input[2]);
            return dwarf;
        }
    }
}
