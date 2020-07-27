using System;
using System.Collections.Generic;

namespace ClassTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many objects to be created: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                persons.Add(Person.ReadPeople());
            }

            for (int i = 0; i < persons.Count; i++)
            {
                Person.PrintPersons(persons[i]);
            }
        }
    }

    //1.Create new class in new fail is prefered
    public class Person
    {
        //2. Properties of the class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }

        //3. Constructor - 
        public Person()
        {
            //this.Age = age; this points to the concrete instance which we are working with at this moment
        }

        //4. Methods
        public static Person ReadPeople()
        {
            Person newPeople = new Person();
            Console.WriteLine("First name:");
            newPeople.FirstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            newPeople.LastName = Console.ReadLine();
            Console.WriteLine("Your age:");
            newPeople.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Mail address:");
            newPeople.Mail = Console.ReadLine();

            return newPeople;
        }

        public static void PrintPersons(Person people)
        {
            Console.WriteLine($"{people.FirstName}, {people.LastName}, {people.Age}, {people.Mail}");
        }
    }
}
