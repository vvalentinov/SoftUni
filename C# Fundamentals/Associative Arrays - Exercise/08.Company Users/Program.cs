namespace _08.Company_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] arr = line.Split(" -> ");
                string company = arr[0];
                string employeeId = arr[1];
                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }
                if (!companies[company].Contains(employeeId))
                {
                    companies[company].Add(employeeId);
                }
                line = Console.ReadLine();
            }
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
