namespace _06._Speed_Racing
{
    using System;

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
                double fuelAmount = double.Parse(parts[1]);
                double fuelConsumptionFor1km = double.Parse(parts[2]);
                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionFor1km,
                    TravelledDistance = 0
                };
                cars[i] = car;
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = parts[1];
                double amountKM = double.Parse(parts[2]);
                Car car = GetCar(carModel, cars);
                car.MovingCar(car, amountKM);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
        private static Car GetCar(string carModel, Car[] cars)
        {
            Car targetCar = new Car();
            foreach (Car car in cars)
            {
                if (car.Model == carModel)
                {
                    targetCar = car;
                    break;
                }
            }
            return targetCar;
        }
    }
}
