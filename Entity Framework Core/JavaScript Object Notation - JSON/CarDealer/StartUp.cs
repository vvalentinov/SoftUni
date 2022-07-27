﻿namespace CarDealer
{
    using AutoMapper;
    using CarDealer.Data;
    using CarDealer.DTO;
    using CarDealer.Models;
    using Newtonsoft.Json;

    internal class StartUp
    {
        private static IMapper mapper;

        static void Main(string[] args)
        {
            CarDealerContext context = new CarDealerContext();
            string suppliers = File.ReadAllText(@"C:\Users\user\Desktop\SoftUni\Entity Framework Core\JavaScript Object Notation - JSON\CarDealer\Datasets");

            Console.WriteLine(ImportSuppliers(context, suppliers));
        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            // InitializeMapper();
            var customersDtos = JsonConvert.DeserializeObject<IEnumerable<CustomerDto>>(inputJson);

            var customers = mapper.Map<IEnumerable<Customer>>(customersDtos);

            context.Customers.AddRange(customers);

            context.SaveChanges();

            return $"Successfully imported {customers.Count()}.";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            // InitializeMapper();

            IEnumerable<CarDto> carDtos = JsonConvert.DeserializeObject<IEnumerable<CarDto>>(inputJson);

            List<Car> cars = new List<Car>();

            foreach (var car in carDtos)
            {
                var currentCar = new Car()
                {
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TravelledDistance
                };

                foreach (var part in car?.PartsId.Distinct())
                {
                    currentCar.PartCars.Add(new PartCar() { PartId = part });
                }

                cars.Add(currentCar);
            }

            context.Cars.AddRange(cars);

            context.SaveChanges();

            return $"Successfully imported {cars.Count()}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            // InitializeMapper();

            List<PartDto> partDtos = JsonConvert.DeserializeObject<List<PartDto>>(inputJson);

            IEnumerable<Part> parts = mapper.Map<IEnumerable<Part>>(partDtos.Where(x => context.Suppliers.Any(s => s.Id == x.SupplierId)));

            context.Parts.AddRange(parts);

            context.SaveChanges();

            return $"Successfully imported {parts.Count()}.";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            // InitializeMapper();
            IEnumerable<SupplierDto> suppliersDto = JsonConvert.DeserializeObject<IEnumerable<SupplierDto>>(inputJson);

            IEnumerable<Supplier> suppliers = mapper.Map<IEnumerable<Supplier>>(suppliersDto);

            context.Suppliers.AddRange(suppliers);

            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}.";
        }

        //public static void InitializeMapper()
        //{
        //    MapperConfiguration configuration = new MapperConfiguration(x => x.AddProfile<CarDealerProfile>());

        //    mapper = new Mapper(configuration);
        //}
    }
}