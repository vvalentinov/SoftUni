﻿namespace _02.Exam_Preparation
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int failedTreshold = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradeSum = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;
            while (failedTimes < failedTreshold)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / solvedProblemsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
