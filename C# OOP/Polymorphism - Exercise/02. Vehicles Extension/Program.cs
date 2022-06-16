namespace _02._Vehicles_Extension
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double fuelQuantityCar = double.Parse(carData[1]);
            double fuelConsumptionCar = double.Parse(carData[2]);
            double tankCapacityCar = double.Parse(carData[3]);
            Car car = new Car(fuelQuantityCar, fuelConsumptionCar, tankCapacityCar);

            string[] truckData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double fuelQuantityTruck = double.Parse(truckData[1]);
            double fuelConsumptionTruck = double.Parse(truckData[2]);
            double tankCapacityTruck = double.Parse(truckData[3]);
            Truck truck = new Truck(fuelQuantityTruck, fuelConsumptionTruck, tankCapacityTruck);

            string[] busData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double fuelQuantityBus = double.Parse(busData[1]);
            double fuelConsumptionBus = double.Parse(busData[2]);
            double tankCapacityBus = double.Parse(busData[3]);
            Bus bus = new Bus(fuelQuantityBus, fuelConsumptionBus, tankCapacityBus);

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
                    else if (vehicle == "Bus")
                    {
                        double fuelNeeded = distance * (bus.FuelConsumption + 1.4);
                        if (fuelNeeded > bus.FuelQuantity)
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                        else
                        {
                            bus.FuelQuantity -= fuelNeeded;
                            Console.WriteLine($"Bus travelled {distance} km");
                        }
                    }
                }
                else if (command == "Refuel")
                {
                    double liters = double.Parse(cmdArgs[2]);
                    if (liters <= 0)
                    {
                        Console.WriteLine("Fuel must be a positive number");
                        continue;
                    }
                    if (vehicle == "Car")
                    {
                        if (car.FuelQuantity + liters > car.TankCapacity)
                        {
                            Console.WriteLine($"Cannot fit {liters} fuel in the tank"); // check
                            continue;
                        }
                        car.FuelQuantity += liters;
                    }
                    else if (vehicle == "Truck")
                    {
                        double finalLiters = liters * 95 * 0.01;
                        if (truck.FuelQuantity + finalLiters > truck.TankCapacity)
                        {
                            Console.WriteLine($"Cannot fit {liters} fuel in the tank"); // check
                            continue;
                        }
                        truck.FuelQuantity += finalLiters;
                    }
                    else if (vehicle == "Bus")
                    {
                        if (bus.FuelQuantity + liters > bus.TankCapacity)
                        {
                            Console.WriteLine($"Cannot fit {liters} fuel in the tank"); // check
                            continue;
                        }
                        bus.FuelQuantity += liters;
                    }
                }
                else if (command == "DriveEmpty")
                {
                    double distance = double.Parse(cmdArgs[2]);
                    double fuelNeeded = distance * bus.FuelConsumption;
                    if (fuelNeeded > bus.FuelQuantity)
                    {
                        Console.WriteLine("Bus needs refueling");
                    }
                    else
                    {
                        bus.FuelQuantity -= fuelNeeded;
                        Console.WriteLine($"Bus travelled {distance} km");
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}