namespace _05._Applied_Arithmetics
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Action<int[]> printCollection = x => Console.WriteLine(string.Join(' ', x));
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                if (line == "print")
                {
                    printCollection(numbers);
                }
                else
                {
                    Func<int, int> commandDelegate = PerformCommand(line);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = commandDelegate(numbers[i]);
                    }
                }
            }
        }
        private static Func<int, int> PerformCommand(string line)
        {
            if (line == "add")
            {
                return x => x + 1;
            }
            else if (line == "multiply")
            {
                return x => x * 2;
            }
            else
            {
                return x => x - 1;
            }
        }
    }
}
