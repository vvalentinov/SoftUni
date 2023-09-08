namespace _01._Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double fuelQuantityCar = double.Parse(carData[1]);
            double fuelConsumptionCar = double.Parse(carData[2]);
            Car car = new Car(fuelQuantityCar, fuelConsumptionCar);

            string[] truckData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double fuelQuantityTruck = double.Parse(truckData[1]);
            double fuelConsumptionTruck = double.Parse(truckData[2]);
            Truck truck = new Truck(fuelQuantityTruck, fuelConsumptionTruck);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string vehicle = cmdArgs[1];
                if (command == "Drive")
                {
                    double distance = double.Parse(cmdArgs[2]);
                    if (vehicle == "Car")
                    {
                        double fuelNeeded = distance * car.FuelConsumption;
                        if (fuelNeeded > car.FuelQuantity)
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                        else
                        {
                            car.FuelQuantity -= fuelNeeded;
                            Console.WriteLine($"Car travelled {distance} km");
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        double fuelNeeded = distance * truck.FuelConsumption;
                        if (fuelNeeded > truck.FuelQuantity)
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                        else
                        {
                            truck.FuelQuantity -= fuelNeeded;
                            Console.WriteLine($"Truck travelled {distance} km");
                        }
                    }
                }
                else if (command == "Refuel")
                {
                    double liters = double.Parse(cmdArgs[2]);
                    if (vehicle == "Car")
                    {
                        car.FuelQuantity += liters;
                    }
                    else if (vehicle == "Truck")
                    {
                        double finalLiters = liters * 95 * 0.01;
                        truck.FuelQuantity += finalLiters;
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}