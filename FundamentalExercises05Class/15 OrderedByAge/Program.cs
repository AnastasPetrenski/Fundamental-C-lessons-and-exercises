using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_OrderedByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                peoples.Add(People.AddPerson(input));
            }
            
            peoples = peoples.OrderBy(x => x.Age).ToList();
            People.PrintPeoples(peoples);
        }
    }

    public class People
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public People()
        {

        }

        public static People AddPerson(List<string> input)
        {
            People person = new People();
            person.Name = input[0];
            person.ID = int.Parse(input[1]);
            person.Age = int.Parse(input[2]);
            return person;
        }

        public static void PrintPeoples(List<People> peoples)
        {
            foreach (var item in peoples)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}
