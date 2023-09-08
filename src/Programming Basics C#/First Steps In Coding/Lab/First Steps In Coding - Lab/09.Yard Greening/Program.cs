namespace _09.Yard_Greening
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double greenArea = double.Parse(Console.ReadLine());
            double firstPrice = greenArea * 7.61;
            double discount = 0.18 * firstPrice;
            double finalPrice = firstPrice - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
