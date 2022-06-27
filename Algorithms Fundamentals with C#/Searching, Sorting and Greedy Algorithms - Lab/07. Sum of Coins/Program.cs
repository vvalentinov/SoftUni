namespace _07._Sum_of_Coins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coins = new Queue<int>(Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .OrderByDescending(x => x));

            int target = int.Parse(Console.ReadLine());

            Dictionary<int, int> selectedCoins = new Dictionary<int, int>();
            int totalCoins = 0;

            while (target > 0 && coins.Count > 0)
            {
                int currentCoin = coins.Dequeue();
                int count = target / currentCoin;

                if (count == 0)
                {
                    continue;
                }

                selectedCoins[currentCoin] = count;
                totalCoins += count;

                target %= currentCoin;
            }

            if (target == 0)
            {
                Console.WriteLine($"Number of coins to take: {totalCoins}");

                foreach (var coin in selectedCoins)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}