namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVAT = x => x + (0.2 * x);
            double[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => addVAT(x))
                .ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
