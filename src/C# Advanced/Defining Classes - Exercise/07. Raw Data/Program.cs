namespace _07._Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = parts[0];
                int engineSpeed = int.Parse(parts[1]);
                int enginePower = int.Parse(parts[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(parts[3]);
                string cargoType = parts[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                double tireOnePressure = double.Parse(parts[5]);
                int tireOneAge = int.Parse(parts[6]);
                Tire first = new Tire(tireOnePressure, tireOneAge);

                double tireTwoPressure = double.Parse(parts[7]);
                int tireTwoAge = int.Parse(parts[8]);
                Tire second = new Tire(tireTwoPressure, tireTwoAge);

                double tireThreePressure = double.Parse(parts[9]);
                int tireThreeAge = int.Parse(parts[10]);
                Tire third = new Tire(tireThreePressure, tireThreeAge);

                double tireFourthPressure = double.Parse(parts[11]);
                int tireFourAge = int.Parse(parts[12]);
                Tire fourth = new Tire(tireFourthPressure, tireFourAge);

                Tire[] tires = new Tire[] { first, second, third, fourth };
                Car car = new Car(model, engine, cargo, tires);
                cars[i] = car;
            }
            string command = Console.ReadLine();
            if (command == "flammable")
            {
                Car[] carsResult = cars
                    .Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250)
                    .ToArray();
                foreach (Car car in carsResult)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                List<Car> carsResult = new List<Car>();
                foreach (Car car in cars)
                {
                    Tire[] tires = car.Tires;
                    bool hasTireWithGivenCondition = CheckTires(tires);
                    if (hasTireWithGivenCondition && car.Cargo.Type == "fragile")
                    {
                        carsResult.Add(car);
                    }
                }
                foreach (Car car in carsResult)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }

        private static bool CheckTires(Tire[] tires)
        {
            foreach (Tire tire in tires)
            {
                if (tire.Pressure < 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
