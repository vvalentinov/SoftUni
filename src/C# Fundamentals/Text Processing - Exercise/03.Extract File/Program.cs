namespace _03.Extract_File
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string[] line = input[input.Length - 1].Split(".");
            Console.WriteLine($"File name: {line[0]}");
            Console.WriteLine($"File extension: {line[1]}");
        }
    }
}
