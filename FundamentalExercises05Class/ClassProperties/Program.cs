using System;

namespace ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            Dog joro = new Dog(Console.ReadLine(), Console.ReadLine());
            //sharo.Name = "Pesho"; we declar it in the constructor body
            //sharo.Age = 52; we declar it in the constructor body
            Console.WriteLine($"Dog name: {sharo.FirstName}, second name: {sharo.LastName}, age:{sharo.Age}");
            Dog pesho = new Dog("Pesho", "Peshov");
            pesho.PrintDog();
            sharo.PrintDog();
            Console.WriteLine(joro.Fullname);
        }   
    }

    public class Dog
    {
        //Properties snipet=prop 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Fullname { get { return FirstName + " " + LastName; } }

        //Constructor - this.Age provide value of the property to the object  
        public Dog(string name, string lastName, int age)
        {
            Console.WriteLine("Constructor body");
            this.FirstName = name;
            this.Age = age;
            this.LastName = lastName;
        }

        //Second Constructor snipet=ctor
        public Dog(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Method of the objects in the class, which are instantieted
        public void PrintDog()
        {
            Console.WriteLine($"Print dog name: {FirstName}, age: {Age}");
        }

    }

    public class DogPropertiesExample
    {
        private int age;
        public string Name { get; set; }
        public int Age 
        { 
            get 
            {
                Console.WriteLine("Getting age");
                return age; 
            } 
            set 
            {
                Console.WriteLine("Setting age");
                if (value > 50)
                {
                    throw new ArgumentException();
                }
                this.age = value; 
            } 
        }
    }
}
