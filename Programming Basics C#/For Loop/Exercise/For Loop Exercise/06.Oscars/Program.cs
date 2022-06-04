namespace _06.Oscars
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());

            double actorPoints = academyPoints;

            for (int i = 0; i < evaluators; i++)
            {
                string evaluator = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                actorPoints += evaluator.Length * points / 2;
                if (actorPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {actorPoints:f1}!");
                    break;
                }
            }
            if (actorPoints <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - actorPoints:f1} more!");
            }
        }
    }
}
