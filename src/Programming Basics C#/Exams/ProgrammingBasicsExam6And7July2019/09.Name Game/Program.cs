namespace _09.Name_Game
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int bestPoints = 0;
            string winner = string.Empty;

            while (name != "Stop")
            {
                int currentPoints = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == name[i])
                    {
                        currentPoints += 10;
                    }
                    else
                    {
                        currentPoints += 2;
                    }
                }

                if (currentPoints >= bestPoints)
                {
                    bestPoints = currentPoints;
                    winner = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {winner} with {bestPoints} points!");
        }
    }
}
