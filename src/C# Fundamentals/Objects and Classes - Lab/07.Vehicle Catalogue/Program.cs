namespace _07.Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        class CatalogueVehicle
        {
            public List<Car> Cars { get; }
            public List<Truck> Trucks { get; }

            public CatalogueVehicle()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }
        static void Main(string[] args)
        {
            CatalogueVehicle catalogueVehicle = new CatalogueVehicle();

            string[] input = Console.ReadLine().Split("/");
            while (input[0] != "end")
            {
                string typeOfVehicle = input[0];
                string brandOfVehicle = input[1];
                string modelOfVehicle = input[2];
                int horseOrWeight = int.Parse(input[3]);

                if (typeOfVehicle == "Car")
                {
                    catalogueVehicle.Cars.Add(new Car
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        HorsePower = horseOrWeight
                    });
                }
                else if (typeOfVehicle == "Truck")
                {
                    catalogueVehicle.Trucks.Add(new Truck()
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        Weight = horseOrWeight
                    });
                }
                input = Console.ReadLine().Split("/");
            }

            if (catalogueVehicle.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                List<Car> orderedCars = catalogueVehicle.Cars.OrderBy(car => car.Brand).ToList();
                foreach (Car carList in orderedCars)
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }

            if (catalogueVehicle.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                List<Truck> orderedTrucks = catalogueVehicle.Trucks.OrderBy(truck => truck.Brand).ToList();
                foreach (Truck truckList in orderedTrucks)
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }
        }
    }
}
