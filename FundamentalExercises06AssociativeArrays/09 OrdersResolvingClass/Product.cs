using System;
using System.Collections.Generic;
using System.Text;

namespace _09_OrdersResolvingClass
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public static Product ReadProduct(List<string> input)
        {
            Product product = new Product();
            product.Name = input[0];
            product.Price = decimal.Parse(input[1]);
            product.Quantity = int.Parse(input[2]);
            return product;
        }

        public static void CalculateOrder(List<Product> orders)
        {
            foreach (var item in orders)
            {
                decimal result = item.Price * item.Quantity;
                Console.WriteLine($"{item.Name} -> {result:f2}");
            }
        }
    }
}
