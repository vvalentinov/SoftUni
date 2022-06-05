namespace _04.Mixed_up_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            List<int> finalResult = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = secondList.Count - 1; j >= 0; j--)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[j]);
                    firstList.RemoveAt(i);
                    secondList.RemoveAt(j);
                    break;
                }
                i = -1;

                if (firstList.Count == 0 || secondList.Count == 0)
                {
                    break;
                }
            }

            if (firstList.Count == 2)
            {
                int first = firstList[0];
                int second = firstList[1];

                if (first < second)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] > first && result[i] < second)
                        {
                            finalResult.Add(result[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", finalResult.OrderBy(n => n)));
                }
                else
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] < first && result[i] > second)
                        {
                            finalResult.Add(result[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", finalResult.OrderBy(n => n)));
                }
            }
            else
            {
                int first = secondList[0];
                int second = secondList[1];

                if (first < second)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] > first && result[i] < second)
                        {
                            finalResult.Add(result[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", finalResult.OrderBy(n => n)));
                }
                else
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] < first && result[i] > second)
                        {
                            finalResult.Add(result[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", finalResult.OrderBy(n => n)));
                }
            }
        }
    }
}
