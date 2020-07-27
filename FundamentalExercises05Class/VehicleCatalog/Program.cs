using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            List<string> inputData = new List<string>(); 
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                inputData = command.Split("/", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (inputData.Contains("Car"))
                {
                    cars.Add(Car.ReadCar(inputData));
                }
                else if (inputData.Contains("Truck"))
                {
                    trucks.Add(Truck.ReadTruck(inputData));
                }
            }

            if (cars.Count > 0)
            {
                cars.Sort((x, y) => x.Brand.CompareTo(y.Brand));
                Car.PrintCars(cars);
            }

            if (trucks.Count > 0)
            {
                trucks = trucks.OrderBy(x => x.Brand).ToList();
                Truck.PrintTrucks(trucks);
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

        public Car()
        {

        }

        public static Car ReadCar(List<string> inputData)
        {
            Car newCar = new Car();
            newCar.Brand = inputData[1];
            newCar.Model = inputData[2];
            newCar.Weight = inputData[3];
            return newCar;
        }

        public static void PrintCars(List<Car> cars)
        {
            Console.WriteLine("Cars:");
            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}hp");
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

        public Truck()
        {

        }

        public static Truck ReadTruck(List<string> inputData)
        {
            Truck newTruck = new Truck();
            newTruck.Brand = inputData[1];
            newTruck.Model = inputData[2];
            newTruck.Weight = inputData[3];
            return newTruck;
        }

        public static void PrintTrucks(List<Truck> ordered)
        {
            Console.WriteLine("Trucks:");
            foreach (Truck item in ordered)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }
        }
    }

    public class Catalog
    {

    }
}
