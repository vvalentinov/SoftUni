namespace _08.Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "3:1")
                {
                    Console.WriteLine(string.Join(" ", input));
                    break;
                }
                string[] commandData = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandData[0];
                if (command == "merge")
                {
                    int startIdx = int.Parse(commandData[1]);
                    int endIdx = int.Parse(commandData[2]);
                    if (startIdx < 0 || startIdx >= input.Count)
                    {
                        startIdx = 0;
                    }
                    if (endIdx >= input.Count)
                    {
                        endIdx = input.Count - 1;
                    }
                    string result = GetResult(startIdx, endIdx, input);
                    input[endIdx] = result;
                    input.RemoveRange(startIdx, endIdx - startIdx);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandData[1]);
                    int number = index;
                    int partitions = int.Parse(commandData[2]);
                    string element = input[index];
                    if (element.Length % partitions == 0)
                    {
                        int chunkLenght = element.Length / partitions;
                        while (element.Length > 0)
                        {
                            string currChunk = element.Substring(0, chunkLenght);
                            input.Insert(number, currChunk);
                            element = element.Remove(0, chunkLenght);
                            number++;
                        }
                        input.RemoveAt(number);
                    }
                    else
                    {
                        int chunkLenght = element.Length / partitions;
                        while (partitions > 1)
                        {
                            string currChunk = element.Substring(0, chunkLenght);
                            input.Insert(number, currChunk);
                            element = element.Remove(0, chunkLenght);
                            number++;
                            partitions--;
                        }
                        input[number] = element;
                    }
                }
            }
        }
        private static string GetResult(int startIdx, int endIdx, List<string> input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIdx; i <= endIdx; i++)
            {
                sb.Append(input[i]);
            }
            var result = sb.ToString();
            return result;
        }
    }
}
