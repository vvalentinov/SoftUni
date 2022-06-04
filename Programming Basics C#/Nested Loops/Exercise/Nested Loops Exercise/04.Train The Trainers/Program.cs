namespace _04.Train_The_Trainers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleInJoury = int.Parse(Console.ReadLine());
            double sumOfAllGrade = 0;
            int countOfGrades = 0;
            while (true)
            {
                string presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    break;
                }
                double sumOfCurrGrades = 0;

                for (int j = 1; j <= numberOfPeopleInJoury; j++)
                {
                    double currGrade = double.Parse(Console.ReadLine());
                    countOfGrades++;
                    sumOfCurrGrades += currGrade;
                    sumOfAllGrade += currGrade;
                }
                double averageCurrPresentation = sumOfCurrGrades / numberOfPeopleInJoury * 1.0;
                Console.WriteLine($"{presentation} - {averageCurrPresentation:f2}.");

            }
            double allAverage = sumOfAllGrade / countOfGrades * 1.0;
            Console.WriteLine($"Student's final assessment is {allAverage:f2}.");
        }
    }
}
