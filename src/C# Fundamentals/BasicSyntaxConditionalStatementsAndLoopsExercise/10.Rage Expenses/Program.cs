namespace _10.Rage_Expenses
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = 0;
            money = lostGames / 2 * headsetPrice;
            money += lostGames / 3 * mousePrice;
            money += lostGames / 6 * keyboardPrice;
            money += lostGames / 12 * displayPrice;
            Console.WriteLine($"Rage expenses: {money:f2} lv.");
        }
    }
}
