namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> times = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!times.ContainsKey(numbers[i]))
                {
                    times.Add(numbers[i], 0);
                }
                times[numbers[i]]++;
            }
            foreach (var item in times)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
