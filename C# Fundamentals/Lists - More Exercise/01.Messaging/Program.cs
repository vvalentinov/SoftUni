namespace _01.Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string text = Console.ReadLine();
            string result = string.Empty;
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNumber = numbers[i];
                while (currNumber != 0)
                {
                    int digit = currNumber % 10;
                    sum += digit;
                    currNumber /= 10;
                }

                if (sum >= text.Length)
                {
                    int index = sum - text.Length;
                    char letter = text[index];
                    result += letter;
                    text = text.Remove(index, 1);
                }
                else
                {
                    for (int j = 0; j <= sum; j++)
                    {
                        if (j == sum)
                        {
                            char letter = text[j];
                            result += letter;
                            text = text.Remove(j, 1);
                        }
                    }
                }
                sum = 0;
            }
            Console.WriteLine(result);
        }
    }
}
