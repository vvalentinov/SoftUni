namespace _09._SoftUni_Exam_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usernamePoints = new Dictionary<string, int>();
            Dictionary<string, int> languagesCount = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "exam finished")
                {
                    break;
                }

                string[] parts = line.Split('-', StringSplitOptions.RemoveEmptyEntries);

                string username = parts[0];
                string language = parts[1];
                if (language == "banned")
                {
                    usernamePoints.Remove(username);
                    continue;
                }

                int points = int.Parse(parts[2]);
                if (usernamePoints.ContainsKey(username) == false)
                {
                    usernamePoints.Add(username, points);

                    if (languagesCount.ContainsKey(language) == false)
                    {
                        languagesCount.Add(language, 1);
                    }
                    else
                    {
                        languagesCount[language] += 1;
                    }
                }
                else
                {
                    if (usernamePoints[username] <= points)
                    {
                        usernamePoints[username] = points;
                    }

                    languagesCount[language] += 1;
                }
            }

            Dictionary<string, int> sortedByPoints = usernamePoints
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var (student, grade) in sortedByPoints)
            {
                Console.WriteLine($"{student} | {grade}");
            }

            Dictionary<string, int> sortedBySubmissions = languagesCount
                .Where(s => s.Value > 0)
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");
            foreach (var (lang, count) in sortedBySubmissions)
            {
                Console.WriteLine($"{lang} - {count}");
            }
        }
    }
}
