namespace _04.Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        class Engine
        {
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
        }
        class Cargo
        {
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }
        }
        class Car
        {
            public Car(string model, Engine engine, Cargo cargo)
            {
                Model = model;
                Engine = engine;
                Cargo = cargo;
            }
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string model = arr[0];
                int engineSpeed = int.Parse(arr[1]);
                int enginePower = int.Parse(arr[2]);
                int cargoWeight = int.Parse(arr[3]);
                string cargoType = arr[4];
                Engine engine = new Engine()
                {
                    EngineSpeed = engineSpeed,
                    EnginePower = enginePower
                };
                Cargo cargo = new Cargo()
                {
                    CargoWeight = cargoWeight,
                    CargoType = cargoType
                };
                Car car = new Car(model, engine, cargo);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            List<Car> filteredCars = new List<Car>();
            if (command == "fragile")
            {
                filteredCars = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000).ToList();
            }
            else
            {
                filteredCars = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
                
            }
            foreach (Car car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
