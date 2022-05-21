namespace _03.Deposit_Calculator
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            double interestOneMonth = (depositSum * (annualInterest / 100)) / 12;
            double sum = depositSum + (depositTerm * interestOneMonth);
            Console.WriteLine(sum);
        }
    }
}
