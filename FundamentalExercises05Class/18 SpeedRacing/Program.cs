using System;
using System.Collections.Generic;
using System.Linq;

namespace _18_SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split().ToList();
                cars.Add(Car.AddCar(data)); 
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> commands = command.Split().ToList();
                Car.DriveCar(commands, cars);
            }

            Car.PrintCars(cars);
        }
    }

    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1km { get; set; }
        public int TraveledKilometers { get; set; }

        public Car()
        {
                
        }

        public static Car AddCar(List<string> data)
        {
            Car car = new Car();
            car.Model = data[0];
            car.FuelAmount = double.Parse(data[1]);
            car.FuelConsumptionFor1km = double.Parse(data[2]);
            car.TraveledKilometers = 0;
            return car;
        }

        public static void DriveCar(List<string> commands, List<Car> cars)
        {
            double distance = cars.Where(x => x.Model == commands[1]).Select(x => x.FuelAmount / x.FuelConsumptionFor1km).FirstOrDefault();
            double consumption = cars.Where(x => x.Model == commands[1]).Select(x => x.FuelConsumptionFor1km * int.Parse(commands[2])).FirstOrDefault();
            if (distance >= int.Parse(commands[2]))
            {
                foreach (var item in cars)
                {
                    if (item.Model == commands[1])
                    {
                        item.FuelAmount -= consumption;
                        item.TraveledKilometers += int.Parse(commands[2]);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

        public static void PrintCars(List<Car> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TraveledKilometers}");
            }
        }
    }
}
