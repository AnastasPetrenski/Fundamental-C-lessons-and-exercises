using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08_NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternHealth = new Regex(@"[^0-9+-\/*\.]");
            Regex patternDamage = new Regex(@"[+-]?[\d+\.]*[\d]+");
            Regex patternOperations = new Regex(@"[\/\*]");
            List<Demon> demonsInfo = new List<Demon>();
            List<string> demonsNames = new List<string>();
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var name in input)
            {
                var health = patternHealth.Matches(name);
                var damage = patternDamage.Matches(name);
                var operations = patternOperations.Matches(name);
                int healthSum = 0;

                foreach (Match letter in health)
                {
                    int singleValue = char.Parse(letter.Value);
                    healthSum += singleValue;
                }

                double damageSum = 0.00;
                foreach (Match number in damage)
                {
                    string singleValue = number.ToString();
                    if (singleValue.StartsWith("-"))
                    {
                        singleValue = singleValue.Remove(0, 1);
                        damageSum -= double.Parse(singleValue);
                    }
                    else
                    {
                        damageSum += double.Parse(singleValue);
                    }
                }

                foreach (Match operation in operations)
                {
                    if (operation.Value == "*")
                    {
                        damageSum *= 2;
                    }
                    else
                    {
                        damageSum /= 2;
                    }
                }

                demonsNames.Add(name);
                demonsInfo.Add(Demon.AddDemon(name, healthSum, damageSum));
            }

            demonsNames.Sort();
            foreach (var item in demonsNames)
            {
                foreach (var demon in demonsInfo)
                {
                    if (demon.Name == item)
                    {
                        Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damge:f2} damage");
                    }
                }
            }
            
        }
    }

    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damge { get; set; }

        public Demon()
        {

        }

        public static Demon AddDemon(string name, int health, double damage)
        {
            Demon demon = new Demon();
            demon.Name = name;
            demon.Health = health;
            demon.Damge = damage;
            return demon;
        }
    }
}
