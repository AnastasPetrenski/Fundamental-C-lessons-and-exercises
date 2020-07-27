using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                List<string> member = Console.ReadLine().Split().ToList();
                Person newPerson = Person.ReadPerson(member);
                family.AddMember(newPerson);
            }

            var oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    public class Family
    {
        private List<Person> membersList;

        public List<Person> MembersList
        {
            get { return membersList; }
            set { membersList = value; }
        }
        public Family()
        {
            this.MembersList = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.MembersList.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.membersList.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static Person ReadPerson(List<string> member)
        {
            Person person = new Person();
            person.Name = member[0];
            person.Age = int.Parse(member[1]);
            return person;
         }
    }
}
