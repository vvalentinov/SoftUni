namespace _07.Projects_Creation
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int oneProject = 3;
            int numberOfHours = numberOfProjects * oneProject;
            Console.WriteLine($"The architect {nameOfArchitect} will need {numberOfHours} hours to complete {numberOfProjects} project/s.");
        }
    }
}
