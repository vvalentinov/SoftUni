﻿namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using BookShop.Models.Enums;
    using Microsoft.EntityFrameworkCore;
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

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books.Where(x => x.Copies < 4200).ToList();

            context.Books.RemoveRange(books);

            context.SaveChanges();

            return books.Count();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.Where(x => x.ReleaseDate.Value.Year < 2010).ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories
                .Select(x => new
                {
                    x.Name,
                    Books = x.CategoryBooks
                            .Select(z => new { z.Book.Title, z.Book.ReleaseDate })
                            .OrderByDescending(z => z.ReleaseDate)
                            .Take(3)
                            .ToList()
                })
                .OrderBy(x => x.Name)
                .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var category in categories)
            {
                builder.AppendLine($"--{category.Name}");

                foreach (var book in category.Books)
                {
                    builder.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(x => new
                {
                    x.Name,
                    TotalProfit = x.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies)
                })
                .OrderByDescending(x => x.TotalProfit)
                .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var category in categories)
            {
                builder.AppendLine($"{category.Name} ${category.TotalProfit:f2}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                                .Select(x => new
                                {
                                    x.FirstName,
                                    x.LastName,
                                    TotalCopies = x.Books.Sum(c => c.Copies)
                                })
                                .OrderByDescending(x => x.TotalCopies)
                                .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var author in authors)
            {
                builder.AppendLine($"{author.FirstName} {author.LastName} - {author.TotalCopies}");
            }

            return builder.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books.Where(x => x.Title.Length > lengthCheck).Count();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                               .Where(x => x.Author.LastName.ToLower().StartsWith(input.ToLower()))
                               .Select(x => new { x.Title, x.Author.FirstName, x.Author.LastName, x.BookId })
                               .OrderBy(x => x.BookId)
                               .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var book in books)
            {
                builder.AppendLine($"{book.Title} ({book.FirstName} {book.LastName})");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var titles = context.Books
                                .Where(x => x.Title.ToLower().Contains(input.ToLower()))
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

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                                 .Where(x => x.FirstName.EndsWith(input))
                                 .Select(x => new { x.FirstName, x.LastName })
                                 .OrderBy(x => x.FirstName)
                                 .ThenBy(x => x.LastName)
                                 .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var author in authors)
            {
                builder.AppendLine($"{author.FirstName} {author.LastName}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var books = context.Books.
                Where(x => x.ReleaseDate.Value < DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture))
                .Select(x => new { x.Title, EditionType = x.EditionType.ToString(), x.Price, x.ReleaseDate })
                .OrderByDescending(x => x.ReleaseDate)
                .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var book in books)
            {
                builder.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

            var books = context.Books
                               .Include(x => x.BookCategories)
                               .ThenInclude(x => x.Category)
                               .ToArray()
                               .Where(book => book.BookCategories.Any(category => categories.Contains(category.Category.Name.ToLower())))
                               .Select(x => x.Title)
                               .OrderBy(x => x)
                               .ToArray();

            StringBuilder builder = new StringBuilder();
            foreach (var book in books)
            {
                builder.AppendLine(book);
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(x => x.ReleaseDate.Value.Year != year)
                .Select(x => new { x.Title, x.BookId })
                .OrderBy(x => x.BookId)
                .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var book in books)
            {
                builder.AppendLine(book.Title);
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                               .Where(x => x.Price > 40)
                               .Select(x => new { x.Title, x.Price })
                               .OrderByDescending(x => x.Price)
                               .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var book in books)
            {
                builder.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            EditionType editionType = Enum.Parse<EditionType>("Gold", false);

            var books = context.Books
                               .Where(x => x.EditionType == editionType && x.Copies < 5000)
                               .Select(x => new { x.Title, x.BookId })
                               .OrderBy(x => x.BookId)
                               .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var book in books)
            {
                builder.AppendLine(book.Title);
            }

            return builder.ToString().TrimEnd();
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