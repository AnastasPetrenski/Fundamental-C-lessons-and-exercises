using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_ShopingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dataPersons = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> dataSinglePerson = new List<string>();
            List<Person> persons = new List<Person>();
            for (int i = 0; i < dataPersons.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataSinglePerson.Add(dataPersons[i]);
                    continue;
                }
                else
                {
                    dataSinglePerson.Add(dataPersons[i]);
                    persons.Add(Person.AddPerson(dataSinglePerson));
                    dataSinglePerson.Clear();
                }

            }
            List<string> dataProducts = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> dataSingleProduct = new List<string>();
            List<Product> products = new List<Product>();
            for (int i = 0; i < dataProducts.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataSingleProduct.Add(dataProducts[i]);
                    continue;
                }
                else
                {
                    dataSingleProduct.Add(dataProducts[i]);
                    products.Add(Product.AddProduct(dataSingleProduct));
                    dataSingleProduct.Clear();
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                List<string> commands = command.Split().ToList();
                decimal costProduct = products.Where(x => x.Name == commands[1]).Select(x => x.Cost).FirstOrDefault();
                if (persons.Where(x => x.Name == commands[0]).Select(x => x.Money).FirstOrDefault() >=
                    products.Where(x => x.Name == commands[1]).Select(x => x.Cost).FirstOrDefault())
                {
                    Console.WriteLine($"{commands[0]} bought {commands[1]}");
                    Person.AddProducts(persons, commands, costProduct);
                    Person.Substraction(persons, commands, costProduct);
                }
                else
                {
                    Console.WriteLine($"{commands[0]} can't afford {commands[1]}");
                }
            }

            Person.PrintPersonProducts(persons);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public Dictionary<string, List<string>> Products { get; set; }

        public static Person AddPerson(List<string> dataPersons)
        {
            Person person = new Person();
            person.Name = dataPersons[0];
            person.Money = decimal.Parse(dataPersons[1]);
            person.Products = new Dictionary<string, List<string>>();
            return person;
        }

        public static void AddProducts(List<Person> persons, List<string> data, decimal costProduct)
        {
            foreach (var item in persons.Where(x => x.Name == data[0]))
            {
                if (item.Products.ContainsKey(data[0]))
                {
                    item.Products[data[0]].Add(data[1]);
                }
                else
                {
                    item.Products.Add(data[0], new List<string>());
                    item.Products[data[0]].Add(data[1]);
                }
            }
        }

        public static void Substraction(List<Person> persons, List<string> commands, decimal costProduct)
        {
            foreach (var item in persons.Where(x => x.Name == commands[0]))
            {
                item.Money -= costProduct;
            }
        }

        public static void PrintPersonProducts(List<Person> persons)
        {
            foreach (var item in persons)
            {
                Console.Write($"{item.Name} - ");
                if (item.Products.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    foreach (var x in item.Products)
                    {
                        Console.WriteLine(string.Join(", ", x.Value));
                    }
                }
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public static Product AddProduct(List<string> dataProducts)
        {
            Product product = new Product();
            product.Name = dataProducts[0];
            product.Cost = decimal.Parse(dataProducts[1]);
            return product;
        }
    }
}
