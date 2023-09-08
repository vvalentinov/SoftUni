namespace _05.Account_Balance
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;
            while (input != "NoMoreMoney")
            {
                double number = double.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {number:f2}");
                total += number;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
