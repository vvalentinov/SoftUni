namespace _04.Sequence_2k_1
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            while (count <= n)
            {
                Console.WriteLine(count);
                count = count * 2 + 1;
            }
        }
    }
}
