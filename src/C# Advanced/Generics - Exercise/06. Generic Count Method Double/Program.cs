namespace _06._Generic_Count_Method_Double
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> numbers = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            double comperator = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(numbers);
            int count = box.GetCount(comperator);
            Console.WriteLine(count);
        }
    }
}
