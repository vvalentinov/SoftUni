namespace _11.Multiplication_Table_2._0
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            } while (times <= 10);
        }
    }
}
