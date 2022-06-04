namespace _09.Padawan_Equipment
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOneLightsaber = double.Parse(Console.ReadLine());
            double priceOneRobe = double.Parse(Console.ReadLine());
            double priceOneBelt = double.Parse(Console.ReadLine());

            double lightsabers = Math.Ceiling(students + students * 0.1);
            double freeBelts = Math.Floor(students * 1.0 / 6);
            double belts = students - freeBelts;
            double robes = students;
            double price = (lightsabers * priceOneLightsaber) + (robes * priceOneRobe) + (belts * priceOneBelt);
            if (price <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(money - price):f2}lv more.");
            }
        }
    }
}
