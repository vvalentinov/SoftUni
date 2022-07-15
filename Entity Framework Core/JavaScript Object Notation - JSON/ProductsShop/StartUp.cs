namespace ProductsShop
{
    using AutoMapper;
    using Newtonsoft.Json;
    using ProducstShop.DataTransferDto;
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

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                                  .Where(x => x.Price >= 500 && x.Price <= 1000)
                                  .Select(x => new
                                  {
                                      name = x.Name,
                                      price = x.Price,
                                      seller = $"{x.Seller.FirstName} {x.Seller.LastName}"
                                  })
                                  .OrderBy(x => x.price)
                                  .ToList();

            string result = JsonConvert.SerializeObject(products, Formatting.Indented);

            return result;
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            InitializeAutomapper();

            IEnumerable<CategoryProductDto> categoriesProductsDto = JsonConvert.DeserializeObject<IEnumerable<CategoryProductDto>>(inputJson);

            IEnumerable<CategoryProduct> categoriesProducts = mapper.Map<IEnumerable<CategoryProduct>>(categoriesProductsDto);

            context.CategoryProducts.AddRange(categoriesProducts);

            context.SaveChanges();

            return $"Successfully imported {categoriesProducts.Count()}";
        }


        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            InitializeAutomapper();

            List<CategoryDto> categoriesDto = JsonConvert.DeserializeObject<IEnumerable<CategoryDto>>(inputJson).Where(x => x.Name != null).ToList();

            IEnumerable<Category> categories = mapper.Map<IEnumerable<Category>>(categoriesDto);

            context.Categories.AddRange(categories);

            context.SaveChanges();

            return $"Successfully imported {categories.Count()}";
        }


        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            InitializeAutomapper();

            IEnumerable<ProductDto> productsDto = JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(inputJson);

            IEnumerable<Product> products = mapper.Map<IEnumerable<Product>>(productsDto);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count()}";
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

        private static void InitializeAutomapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });

            mapper = config.CreateMapper();
        }
    }
}