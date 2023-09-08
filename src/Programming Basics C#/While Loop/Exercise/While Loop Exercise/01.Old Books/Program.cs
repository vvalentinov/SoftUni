namespace _01.Old_Books
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string nextBookName = Console.ReadLine();

            int counter = 0;
            bool isBookFound = false;
            while (isBookFound == false)
            {
                if (nextBookName == favouriteBook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
