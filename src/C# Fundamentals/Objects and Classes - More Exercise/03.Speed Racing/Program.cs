namespace _03.Speed_Racing
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelPerKilometer { get; set; }
            public int TraveledDistance { get; set; }

            public bool MoveSuccseful(List<Car> cars, string model, int kilometers, double fuelToBeUsed)
            {
                foreach (Car car in cars)
                {
                    if (car.Model == model)
                    {
                        if (fuelToBeUsed <= car.FuelAmount)
                        {
                            return true;
                        }
                        break;
                    }
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string model = arr[0];
                double fuelAmount = double.Parse(arr[1]);
                double fuelPerKilometer = double.Parse(arr[2]);
                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelPerKilometer = fuelPerKilometer,
                    TraveledDistance = 0
                };
                cars.Add(car);
            }
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] arr = line.Split();
                string model = arr[1];
                int kilometers = int.Parse(arr[2]);

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        double fuelToBeUsed = kilometers * car.FuelPerKilometer;
                        if (!car.MoveSuccseful(cars, model, kilometers, fuelToBeUsed))
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                            break;
                        }

                        car.FuelAmount -= fuelToBeUsed;
                        car.TraveledDistance += kilometers;
                        break;
                    }
                }
                line = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
