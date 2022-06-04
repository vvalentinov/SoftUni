namespace _06.Even_and_Odd_Subtraction
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                if (curr % 2 == 0)
                {
                    evenSum += curr;
                }
                else
                {
                    oddSum += curr;
                }
            }
            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
