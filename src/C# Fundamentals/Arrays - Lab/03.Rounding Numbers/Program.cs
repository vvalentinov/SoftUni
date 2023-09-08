namespace _03.Rounding_Numbers
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{Convert.ToDecimal(nums[i])} => {Convert.ToDecimal(Math.Round(nums[i], MidpointRounding.AwayFromZero))}");
            }
        }
    }
}
