using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string color = input[0];
                if (!dragons.ContainsKey(color))
                {
                    dragons.Add(color, new List<Dragon>());
                    dragons[color].Add(Dragon.AddDragon(input));
                    //Start with capital ???
                }
                else
                {
                    string name = input[1];
                    if (!dragons[color].Any(x => x.Name == name))
                    {
                        dragons[color].Add(Dragon.AddDragon(input));
                    }
                    else
                    {
                        int damage = 0;
                        int health = 0;
                        int armor = 0;
                        if (input[2] == "null")
                        {
                            damage = 45;
                        }
                        else
                        {
                            damage = int.Parse(input[2]);
                        }
                        if (input[3] == "null")
                        {
                            health = 250;
                        }
                        else
                        {
                            health = int.Parse(input[3]);
                        }
                        if (input[4] == "null")
                        {
                            armor = 10;
                        }
                        else
                        {
                            armor = int.Parse(input[4]);
                        }
                        
                        foreach (var dragon in dragons.Where(x => x.Key == color))
                        {
                            dragon.Value.Where(x => x.Name == name).Select(x => x.Damage = damage).ToList();
                            dragon.Value.Where(x => x.Name == name).Select(x => x.Health = health).ToList();
                            dragon.Value.Where(x => x.Name == name).Select(x => x.Armor = armor).ToList();
                        }
                    }
                }
            }

            foreach (var colorTypeDragons in dragons)
            {
                string color = colorTypeDragons.Key;
                var avgDamage = dragons[color].Sum(x => x.Damage) / (double)dragons[color].Count*1.00;
                var avgHealth = dragons[color].Sum(x => x.Health) / (double)dragons[color].Count*1.00;
                var avgArmor = dragons[color].Sum(x => x.Armor) / (double)dragons[color].Count*1.00;
                Console.WriteLine($"{color}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");
                foreach (var dragon in colorTypeDragons.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    public class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; } = 45;
        public int Health { get; set; } = 250;
        public int Armor { get; set; } = 10;

        public Dragon()
        {

        }

        public static Dragon AddDragon(List<string> input)
        {
            Dragon dragon = new Dragon();
            dragon.Name = input[1];
            if (input[2] != "null")
            {
                dragon.Damage = int.Parse(input[2]);
            }
            if (input[3] != "null")
            {
                dragon.Health = int.Parse(input[3]);
            }
            if (input[4] != "null")
            {
                dragon.Armor = int.Parse(input[4]);
            }
            
            return dragon;
        }
    }
}
