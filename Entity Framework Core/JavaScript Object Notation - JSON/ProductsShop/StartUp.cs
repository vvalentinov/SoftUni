namespace ProductsShop
{
    using AutoMapper;
    using Newtonsoft.Json;
    using ProductsShop.Data;
    using ProductsShop.DataTransferDto;
    using ProductsShop.Models;

    internal class StartUp
    {
        private static IMapper mapper;

        public static async Task Main(string[] args)
        {
            ProductShopContext context = new ProductShopContext();
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
            Console.WriteLine("Database created.");


            string users = await File.ReadAllTextAsync(@"C:\SoftUni\Entity Framework Core - февруари 2021\Exercise JSON Processing\08. JSON-Processing-Product-Shop-Skeleton\ProductShop\Datasets\users.json");

            string result = ImportUsers(context, users);
            Console.WriteLine(result);
            Console.WriteLine($"{context.Users.Count()}");
        }

        private static void InitializeAutomapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });

            mapper = config.CreateMapper();
        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            InitializeAutomapper();
            IEnumerable<UserDto> usersDto = JsonConvert.DeserializeObject<IEnumerable<UserDto>>(inputJson);

            IEnumerable<User> users = mapper.Map<IEnumerable<User>>(usersDto);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count()}";
        }
    }
}