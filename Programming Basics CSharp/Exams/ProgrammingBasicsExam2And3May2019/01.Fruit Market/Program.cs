namespace _01.Fruit_Market
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPriceForKg = double.Parse(Console.ReadLine());
            double bananasInKg = double.Parse(Console.ReadLine());
            double orangesInKg= double.Parse(Console.ReadLine());
            double raspberriesInKg = double.Parse(Console.ReadLine());
            double strawberriesInKg = double.Parse(Console.ReadLine());

            double strawberriesPrice = strawberriesPriceForKg * strawberriesInKg;
            double raspberriesPriceForKg = strawberriesPriceForKg / 2;
            double orangesPriceForKg = raspberriesPriceForKg - (raspberriesPriceForKg * 0.4);
            double bananasPriceForKg = raspberriesPriceForKg - (raspberriesPriceForKg * 0.8);

            double total = strawberriesPrice + (bananasInKg * bananasPriceForKg) + (orangesInKg * orangesPriceForKg) + (raspberriesInKg * raspberriesPriceForKg);
            Console.WriteLine($"{total:f2}");
        }
    }
}
