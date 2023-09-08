namespace ProductsShop
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
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

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                                .Include(x => x.ProductsSold)
                                .ToList()
                                .Where(x => x.ProductsSold.Any(p => p.BuyerId != null))
                                .Select(x => new
                                {
                                    firstName = x.FirstName,
                                    lastName = x.LastName,
                                    age = x.Age,
                                    soldProducts = new
                                    {
                                        count = x.ProductsSold.Where(u => u.BuyerId != null).Count(),
                                        products = x.ProductsSold.Where(u => u.BuyerId != null).Select(p => new
                                        {
                                            name = p.Name,
                                            price = p.Price
                                        })
                                    }
                                }).OrderByDescending(x => x.soldProducts.count).ToList();

            JsonSerializerSettings settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

            var resultObject = new
            {
                usersCount = users.Count(),
                users = users
            };

            var json = JsonConvert.SerializeObject(resultObject, Formatting.Indented, settings);

            return json;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                                    .OrderByDescending(x => x.CategoryProducts.Count)
                                    .Select(x => new
                                    {
                                        category = x.Name,
                                        productsCount = x.CategoryProducts.Count,
                                        averagePrice = $"{x.CategoryProducts.Sum(p => p.Product.Price) / x.CategoryProducts.Count:f2}",
                                        totalRevenue = $"{x.CategoryProducts.Sum(p => p.Product.Price):f2}"
                                    })
                                    .ToList();


            string json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            return json;
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                               .Where(x => x.ProductsSold.Any(p => p.BuyerId != null))
                               .Select(x => new
                               {
                                   firstName = x.FirstName,
                                   lastName = x.LastName,
                                   soldProducts = x.ProductsSold.Where(p => p.BuyerId != null).Select(p => new
                                   {
                                       name = p.Name,
                                       price = p.Price,
                                       buyerFirstName = p.Buyer.FirstName,
                                       buyerLastName = p.Buyer.LastName
                                   })
                               })
                               .OrderBy(x => x.lastName)
                               .ThenBy(x => x.firstName)
                               .ToList();

            string result = JsonConvert.SerializeObject(users, Formatting.Indented);

            return result;
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