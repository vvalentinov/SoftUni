namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using BookShop.Models.Enums;
    using System.Text;

    internal class StartUp
    {
        static void Main(string[] args)
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            string command = Console.ReadLine();

            Console.WriteLine(GetBooksByAgeRestriction(db, command));
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var titles = context.Books
                                .Where(x => x.AgeRestriction == ageRestriction)
                                .Select(x => x.Title)
                                .OrderBy(x => x)
                                .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var title in titles)
            {
                builder.AppendLine(title);
            }

            return builder.ToString().TrimEnd();
        }
    }
}