namespace _02._Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<decimal>());
                }
                grades[name].Add(grade);
            }

            foreach (var item in grades)
            {
                StringBuilder allGrades = new StringBuilder();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    allGrades.Append($"{item.Value[i]:f2} ");
                }
                Console.WriteLine($"{item.Key} -> {allGrades}(avg: {item.Value.Average():f2})");
            }
        }
    }
}
