namespace _7._Pascal_Triangle
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                long[] currRow = new long[i + 1];
                triangle[i] = currRow;
                currRow[0] = 1;
                currRow[i] = 1;
                for (int col = 1; col < currRow.Length - 1; col++)
                {
                    currRow[col] = triangle[i - 1][col] + triangle[i - 1][col - 1];
                }
            }

            foreach (var item in triangle)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
