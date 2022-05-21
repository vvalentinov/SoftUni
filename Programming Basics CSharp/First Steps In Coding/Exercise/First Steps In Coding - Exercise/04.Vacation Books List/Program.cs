namespace _04.Vacation_Books_List
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesInCurrentBook = int.Parse(Console.ReadLine());
            double pagesInOneHour = double.Parse(Console.ReadLine());
            int numberOfDaysToReadBook = int.Parse(Console.ReadLine());

            double timeToReadOneBook = pagesInCurrentBook / pagesInOneHour;
            double numberOfHoursForOneDay = timeToReadOneBook / numberOfDaysToReadBook;
            Console.WriteLine(Math.Floor(numberOfHoursForOneDay));
        }
    }
}
