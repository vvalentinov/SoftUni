namespace _04.CleverLily
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double dishwasherPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int savedMoney = 0;
            int money = 10;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += money;
                    money += 10;
                }
                else
                {
                    toys++;
                }
            }

            int moneySavedFromToys = toys * toyPrice;
            toys = age % 2 == 0 ? toys : toys - 1;
            savedMoney += moneySavedFromToys - toys;

            if (savedMoney >= dishwasherPrice)
            {
                Console.WriteLine($"Yes! {savedMoney - dishwasherPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {dishwasherPrice - savedMoney:f2}");
            }
        }
    }
}
