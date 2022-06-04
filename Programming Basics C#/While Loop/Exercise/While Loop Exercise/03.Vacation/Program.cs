namespace _03.Vacation
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacation = double.Parse(Console.ReadLine());
            double myMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;
            while (myMoney < moneyNeededForVacation && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "spend")
                {
                    myMoney -= sum;
                    if (myMoney <= 0)
                    {
                        myMoney = 0;
                    }
                    spendingCounter++;
                }
                else if (command == "save")
                {
                    myMoney += sum;
                    spendingCounter = 0;
                }
            }
            if (myMoney >= moneyNeededForVacation)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
        }
    }
}
