namespace _03.Gaming_Store
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double sum = 0;
            do
            {
                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${budget:f2}");
                    break;
                }
                if (game == "OutFall 4")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        sum += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        budget -= 15.99;
                        sum += 15.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (budget >= 19.99)
                    {
                        budget -= 19.99;
                        sum += 19.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        budget -= 59.99;
                        sum += 59.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        budget -= 29.99;
                        sum += 29.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        sum += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            } while (budget > 0);

            if (budget <= 0)
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
