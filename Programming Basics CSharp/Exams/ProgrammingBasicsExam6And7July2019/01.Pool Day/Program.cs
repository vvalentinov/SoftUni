namespace _01.Pool_Day
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double priceForOneDeckChair = double.Parse(Console.ReadLine());
            double priceForOneUmbrella = double.Parse(Console.ReadLine());

            double totalTax = tax * numberOfPeople;
            double numberOFDeckChairs = Math.Ceiling(numberOfPeople * 0.75);
            double numberOfUmbrellas = Math.Ceiling(numberOfPeople * 1.0 / 2);
            double priceForDeckChairs = numberOFDeckChairs * priceForOneDeckChair;
            double priceForUmbrellas = numberOfUmbrellas * priceForOneUmbrella;
            double total = totalTax + priceForDeckChairs + priceForUmbrellas;
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
