namespace _04.Toy_Shop
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());

            int puzzlesNumber = int.Parse(Console.ReadLine());
            int talkingPuppetsNumber = int.Parse(Console.ReadLine());
            int teddyBearsNumber = int.Parse(Console.ReadLine());
            int minionsNumber = int.Parse(Console.ReadLine());
            int trucksNumber = int.Parse(Console.ReadLine());

            double totalPrice = (puzzlesNumber * 2.6) + (talkingPuppetsNumber * 3) + (teddyBearsNumber * 4.1) + (minionsNumber * 8.2) + (trucksNumber * 2);
            if (puzzlesNumber + talkingPuppetsNumber + teddyBearsNumber + minionsNumber + trucksNumber >= 50)
            {
                totalPrice -= totalPrice * 0.25;
            }

            totalPrice -= totalPrice * 0.1;
            if (totalPrice >= holidayPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - holidayPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - totalPrice:f2} lv needed.");
            }
        }
    }
}
