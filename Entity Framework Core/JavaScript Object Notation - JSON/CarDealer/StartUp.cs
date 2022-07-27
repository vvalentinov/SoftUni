namespace CarDealer
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

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                                   .Where(x => x.Sales.Count() >= 1)
                                   .Select(x => new
                                   {
                                       fullName = x.Name,
                                       boughtCars = x.Sales.Count(),
                                       spentMoney = x.Sales.Sum(p => p.Car.PartCars.Sum(s => s.Part.Price))
                                   }).ToList();



            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);

            return json;
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                              .Select(x => new
                              {
                                  car = new
                                  {
                                      Make = x.Make,
                                      Model = x.Model,
                                      TravelledDistance = x.TravelledDistance
                                  },
                                  parts = x.PartCars.Select(p => new
                                  {
                                      Name = p.Part.Name,
                                      Price = $"{p.Part.Price:f2}"
                                  }).ToList()
                              }).ToList();


            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);

            return json;
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                                   .Where(x => x.IsImporter == false)
                                   .Select(x => new
                                   {
                                       Id = x.Id,
                                       Name = x.Name,
                                       PartsCount = x.Parts.Count()
                                   }).ToList();

            string json = JsonConvert.SerializeObject(suppliers, Formatting.Indented);

            return json;
        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                              .Where(x => x.Make == "Toyota")
                              .OrderBy(x => x.Model)
                              .ThenByDescending(x => x.TravelledDistance)
                              .Select(x => new
                              {
                                  Id = x.Id,
                                  Make = x.Make,
                                  Model = x.Model,
                                  TravelledDistance = x.TravelledDistance
                              })
                              .ToList();

            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);

            return json;
        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                                   .OrderBy(x => x.BirthDate)
                                   .ThenBy(x => x.IsYoungDriver)
                                   .Select(x => new
                                   {
                                       Name = x.Name,
                                       BirthDate = x.BirthDate.ToString("dd/MM/yyyy"),
                                       IsYoungDriver = x.IsYoungDriver
                                   })
                                   .ToList();

            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);

            return json;
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            // InitializeMapper();
            var salesDtos = JsonConvert.DeserializeObject<IEnumerable<SaleDto>>(inputJson);

            var sales = mapper.Map<IEnumerable<Sale>>(salesDtos);

            context.Sales.AddRange(sales);

            context.SaveChanges();

            return $"Successfully imported {sales.Count()}.";
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