namespace _06.Courses
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (command != "end")
            {
                string[] cmdArg = command.Split(" : ");
                string courseName = cmdArg[0];
                string studentName = cmdArg[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
                command = Console.ReadLine();
            }
            foreach (var currCourse in courses)
            {
                Console.WriteLine($"{currCourse.Key}: {currCourse.Value.Count}");
                foreach (var item in currCourse.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
