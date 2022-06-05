namespace _07.Student_Academy
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(student))
                {
                    students.Add(student, grade);
                }
                else
                {
                    foreach (var item in students)
                    {
                        if (item.Key == student)
                        {
                            count++;
                        }
                    }
                    students[student] = (students[student] + grade) / count;
                    count = 1;
                }
            }
            foreach (var item in students)
            {
                if (item.Value < 4.50)
                {
                    students.Remove(item.Key);
                }
            }
            
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
