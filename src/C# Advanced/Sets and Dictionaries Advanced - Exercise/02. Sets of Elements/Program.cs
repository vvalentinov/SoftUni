namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstLenght = lenghts[0];
            int secondLenght = lenghts[1];
            HashSet<int> firstSet = new HashSet<int>(firstLenght);
            HashSet<int> secondSet = new HashSet<int>(secondLenght);
            for (int i = 0; i < firstLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < secondLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            HashSet<int> result = new HashSet<int>();
            foreach (int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    result.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
