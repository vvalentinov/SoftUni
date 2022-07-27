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