using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> commands = command.Split().ToList();
                List<int> change = new List<int>();
                List<int> reused = new List<int>();
                if (commands.Contains("decrease"))
                {
                    change = numbers.ConvertAll(x => x = x - 1).OrderBy(x => x).ToList();
                    numbers.ToList().ForEach(x => x = x - 1);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));

            //New task 

            List<Dog> dogs = new List<Dog>()
            {
                new Dog { Name = "Rex", Age = 3 },
                new Dog { Name = "Pesho", Age = 4},
                new Dog { Name = "Gosho", Age = 1}
            };

            var names = dogs.Select(x => x.Name);
            var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
            var sortedDogs = dogs.OrderBy(x => x.Name).Select(x => x.Name);
            var evenNumbers = dogs.Where(x => x.Age % 2 == 0).ToList();// not worked
            var oddNumbers = dogs.FindAll(x => x.Age % 2 != 0).Select(x => x.Age);
                       
            foreach (var name in sortedDogs)
            {
                Console.WriteLine(name);
            }
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
