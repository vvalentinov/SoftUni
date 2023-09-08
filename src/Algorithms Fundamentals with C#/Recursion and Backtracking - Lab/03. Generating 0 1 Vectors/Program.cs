namespace _03._Generating_0_1_Vectors
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            GenerateVectors(numbers, 0);
        }
        private static void GenerateVectors(int[] numbers, int index)
        {
            if (index >= numbers.Length)
            {
                Console.WriteLine(string.Join(string.Empty, numbers));
                return;
            }
            for (int i = 0; i <= 1; i++)
            {
                numbers[index] = i;
                GenerateVectors(numbers, index + 1);
            }
        }
    }
}
