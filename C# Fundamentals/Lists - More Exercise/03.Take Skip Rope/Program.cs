namespace _03.Take_Skip_Rope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbersList = new List<int>();
            List<string> nonNumbersList = new List<string>();
            List<string> resultList = new List<string>();
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = int.Parse(char.ToString(input[i]));
                    numbersList.Add(digit);
                }
                else
                {
                    nonNumbersList.Add(char.ToString(input[i]));
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }
            for (int i = 0; i < takeList.Count; i++)
            {
                int countTake = takeList[i];
                int countSkip = skipList[i];
                if (countTake > nonNumbersList.Count)
                {
                    countTake = nonNumbersList.Count;
                }
                if (countSkip > nonNumbersList.Count)
                {
                    countSkip = nonNumbersList.Count;
                }
                if (countTake > 0)
                {
                    resultList = nonNumbersList.Take(countTake).ToList();
                    foreach (var item in resultList)
                    {
                        result += item;
                    }
                    nonNumbersList.RemoveRange(0, countTake);
                }
                if (countSkip > 0)
                {
                    nonNumbersList = nonNumbersList.Skip(countSkip).ToList();
                }
            }
            Console.WriteLine(result);
        }
    }
}
