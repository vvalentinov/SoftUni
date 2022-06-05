namespace _08.Letters_Change_Numbers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];

                char firstLetter = curr[0];

                char lastLetter = curr[curr.Length - 1];

                double number = double.Parse(curr.Substring(1, curr.Length - 2));

                int firstElementIndex = alpha.IndexOf(char.ToUpper(firstLetter));

                int secondElementIndex = alpha.IndexOf(char.ToUpper(lastLetter));

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= firstElementIndex + 1;
                }
                else
                {
                    number *= firstElementIndex + 1;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number -= secondElementIndex + 1;
                }
                else
                {
                    number += secondElementIndex + 1;
                }

                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
