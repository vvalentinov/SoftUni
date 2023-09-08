namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            List<Car> specialCars = new List<Car>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "No more tires")
                {
                    break;
                }
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire tireOne = new Tire(int.Parse(parts[0]), double.Parse(parts[1]));
                Tire tireTwo = new Tire(int.Parse(parts[2]), double.Parse(parts[3]));
                Tire tireThree = new Tire(int.Parse(parts[4]), double.Parse(parts[5]));
                Tire tireFour = new Tire(int.Parse(parts[6]), double.Parse(parts[7]));
                Tire[] arrTires = new Tire[4] { tireOne, tireTwo, tireThree, tireFour };
                tires.Add(arrTires);
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Engines done")
                {
                    break;
                }
                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(parts[0]);
                double cubicCapacity = double.Parse(parts[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Show special")
                {
                    break;
                }
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = parts[0];
                string model = parts[1];
                int year = int.Parse(parts[2]);
                double fuelQuantity = double.Parse(parts[3]);
                double fuelConsumption = double.Parse(parts[4]);
                int engineIndex = int.Parse(parts[5]);
                int tiresIndex = int.Parse(parts[6]);
                Tire[] fourTires = tires[tiresIndex];
                Engine engine = engines[engineIndex];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, fourTires);
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                double sumPressure = GetSumTiresPressure(car);
                if ((car.Year >= 2017)
                    && (car.Engine.HorsePower > 330)
                    && (sumPressure >= 9 && sumPressure <= 10))
                {
                    car.Drive(20);
                    specialCars.Add(car);
                }
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }

        }

        private static double GetSumTiresPressure(Car car)
        {
            Tire[] tires = car.Tires;
            double sum = 0;
            for (int i = 0; i < tires.Length; i++)
            {
                sum += tires[i].Pressure;
            }
            return sum;
        }
    }
}
