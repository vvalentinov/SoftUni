namespace _05.Movie_Ratings
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());

            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            double sumOfRatings = 0;
            string movie1 = string.Empty;
            string movie2 = string.Empty;
            for (int i = 1; i <= movies; i++)
            {
                string currMovie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                sumOfRatings += rating;
                if (rating > maxRating)
                {
                    movie1 = currMovie;
                    maxRating = rating;
                }
                if (rating < minRating)
                {
                    movie2 = currMovie;
                    minRating = rating;
                }
            }
            Console.WriteLine($"{movie1} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{movie2} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {sumOfRatings / movies * 1.0:f1}");
        }
    }
}
