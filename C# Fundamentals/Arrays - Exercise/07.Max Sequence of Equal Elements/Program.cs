namespace _07.Max_Sequence_of_Equal_Elements
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int bestCount = 0;
            int bestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string currElemt = arr[i];
                int currCount = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currElemt == arr[j])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
