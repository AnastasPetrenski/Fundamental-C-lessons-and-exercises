using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14_VehicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (data[0] == "car")
                {
                    cars.Add(Car.ReadCar(data));
                }
                else if (data[0] == "truck")
                {
                    trucks.Add(Truck.ReadTruck(data));
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                if (cars.Select(x => x.Model).Contains(command))
                {
                    Car.PrintCar(cars, command);
                }
                else if (trucks.Select(x => x.Model).Contains(command))
                {
                    Truck.PrintTruck(trucks, command);
                }
            }

            double avgC = Car.Average(cars);
            Console.WriteLine($"Cars have average horsepower of: {avgC:f2}.");
            double avgT = Truck.Average(trucks);
            Console.WriteLine($"Trucks have average horsepower of: {avgT:f2}.");
        }
    }

    public class Car
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Horsepower { get; set; }

        public Car()
        {

        }

        public static Car ReadCar(List<string> data)
        {
            Car car = new Car();
            car.Type = data[0];
            car.Model = data[1];
            car.Color = data[2];
            car.Horsepower = data[3];
            return car;
        }

        public static void PrintCar(List<Car> cars, string model)
        {
            var models = cars.Select(x => x.Model).Where(x => x == model).ToList();
            foreach (var item in cars)
            {
                if (item.Model == model)
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Horsepower: {item.Horsepower}");
                }
            }
        }

        public static double Average(List<Car> cars)
        {
            double avg = 0.00;
            if (cars.Select(x => x.Horsepower).Count() == 0)
            {
                avg = 0.00;
            }
            else
            {
                avg = cars.Select(x => int.Parse(x.Horsepower)).Average();
            }
            return avg;
        }
    }

    public class Truck
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Horsepower { get; set; }

        public Truck()
        {

        }

        public static Truck ReadTruck(List<string> data)
        {
            Truck truck = new Truck();
            truck.Type = data[0];
            truck.Model = data[1];
            truck.Color = data[2];
            truck.Horsepower = data[3];
            return truck;
        }

        public static void PrintTruck(List<Truck> trucks, string model)
        {
            //var models = trucks.Select(x => x.Model).Where(x => x == model).ToList();
            foreach (var item in trucks)
            {
                if (item.Model == model)
                {
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Horsepower: {item.Horsepower}");
                }
            }
        }

        public static double Average(List<Truck> trucks)
        {
            double avg = 0;
            if (trucks.Select(x => x.Horsepower).Count() == 0)
            {
                avg = 0.00;
            }
            else
            {
                avg = trucks.Select(x => int.Parse(x.Horsepower)).Average();
            }
            return avg;
        }
    }
}
