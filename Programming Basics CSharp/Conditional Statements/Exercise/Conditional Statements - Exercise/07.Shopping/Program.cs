namespace _07.Shopping
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int memory = int.Parse(Console.ReadLine());

            double priceForVideocards = videocards * 250;
            double priceForProcessors = (priceForVideocards * 0.35) * processors;
            double priceForMemory = (priceForVideocards * 0.1) * memory;
            double totalSum = priceForVideocards + priceForProcessors + priceForMemory;
            if (videocards > processors)
            {
                totalSum -= (totalSum * 0.15);
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:f2} leva more!");
            }
        }
    }
}
