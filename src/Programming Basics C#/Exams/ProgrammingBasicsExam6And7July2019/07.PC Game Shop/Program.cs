namespace _07.PC_Game_Shop
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGames = int.Parse(Console.ReadLine());

            int countHeartStone = 0;
            int countFortnite = 0;
            int countOverwatch = 0;
            int countOthers = 0;
            for (int i = 1; i <= numberOfGames; i++)
            {
                string nameOfGame = Console.ReadLine();
                if (nameOfGame == "Hearthstone")
                {
                    countHeartStone++;
                }
                else if (nameOfGame == "Fornite")
                {
                    countFortnite++;
                }
                else if (nameOfGame == "Overwatch")
                {
                    countOverwatch++;
                }
                else
                {
                    countOthers++;
                }
            }
            Console.WriteLine($"Hearthstone - {countHeartStone * 1.0 / numberOfGames * 100:f2}%");
            Console.WriteLine($"Fornite - {countFortnite * 1.0 / numberOfGames * 100:f2}%");
            Console.WriteLine($"Overwatch - {countOverwatch * 1.0 / numberOfGames * 100:f2}%");
            Console.WriteLine($"Others - {countOthers * 1.0 / numberOfGames * 100:f2}%");
        }
    }
}
