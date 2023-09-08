namespace _04.Cinema_Voucher
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            int countTickets = 0;
            int countOtherPurchases = 0;
            string purchase = Console.ReadLine();
            bool hasPurchaseEnded = true;
            while (purchase != "End")
            {
                if (purchase.Length > 8)
                {
                    int priceTickets = purchase[0] + purchase[1];
                    if (priceTickets > voucher)
                    {
                        Console.WriteLine($"{countTickets}");
                        Console.WriteLine($"{countOtherPurchases}");
                        hasPurchaseEnded = false;
                        break;
                    }
                    voucher -= priceTickets;
                    countTickets++;
                }
                else if (purchase.Length <= 8)
                {
                    int priceOtherThings = purchase[0];
                    if (priceOtherThings > voucher)
                    {
                        Console.WriteLine($"{countTickets}");
                        Console.WriteLine($"{countOtherPurchases}");
                        hasPurchaseEnded = false;
                        break;
                    }
                    voucher -= priceOtherThings;
                    countOtherPurchases++;
                }
                purchase = Console.ReadLine();
            }
            if (hasPurchaseEnded)
            {
                Console.WriteLine($"{countTickets}");
                Console.WriteLine($"{countOtherPurchases}");
            }
        }
    }
}
