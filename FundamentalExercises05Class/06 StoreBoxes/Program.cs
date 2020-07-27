using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            List<string> boxData = new List<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                boxData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                //boxData.Add((decimal.Parse(boxData[2]) * decimal.Parse(boxData[3])).ToString());
                boxes.Add(Box.ReadBox(boxData));
            }
            //boxes.Sort((x, y) => x.TotalPrice.CompareTo(y.TotalPrice));
            //boxes.Reverse();
            List<Box> ordered = boxes.OrderByDescending(x => x.TotalPrice).ToList();
            Box.PrintBoxes(ordered);
        }
    }

    public class Box
    {   
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }   
        public decimal TotalPrice { get; set; }
        public Box()
        {

        }

        public static Box ReadBox(List<string> boxData)
        {
            //{Serial Number} {Item Name} {Item Quantity} {itemPrice}
            Box singleBox = new Box();
            singleBox.SerialNumber = boxData[0];
            singleBox.ItemName = boxData[1];
            singleBox.Quantity = int.Parse(boxData[2]);
            singleBox.PriceBox = decimal.Parse(boxData[3]);
            singleBox.TotalPrice = singleBox.Quantity * singleBox.PriceBox;
            return singleBox;
        }

        public static void PrintBoxes(List<Box> boxes)
        {
            foreach (Box item in boxes)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.ItemName} - ${item.PriceBox:f2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.TotalPrice:f2}");
            }
        }
    }
    //class Item
    //{
    //    public string Name { get; set; }
    //    public decimal Price { get; set; }
    //}
}
