namespace _06._Songs_Queue
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>();
            foreach (string song in songs)
            {
                queue.Enqueue(song);
            }
            while (queue.Count > 0)
            {
                string line = Console.ReadLine();
                if (line == "Play")
                {
                    queue.Dequeue();
                }
                else if (line == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    int index = line.IndexOf(' ');
                    string song = line.Substring(index + 1);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
