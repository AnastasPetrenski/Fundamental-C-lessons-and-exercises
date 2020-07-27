using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_OrdersResolvingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> orders = new List<Product>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "buy")
            {
                List<string> input = command.Split().ToList();
                if (orders.Any(x => x.Name == input[0]))
                {
                    orders.Where(x => x.Name == input[0]).Select(x => x.Price = decimal.Parse(input[1])).ToList();
                    orders.Where(x => x.Name == input[0]).Select(x => x.Quantity += int.Parse(input[2])).ToList();
                }
                else
                {
                    orders.Add(Product.ReadProduct(input));
                }
            }
            
            Product.CalculateOrder(orders);
        }
    }

}
