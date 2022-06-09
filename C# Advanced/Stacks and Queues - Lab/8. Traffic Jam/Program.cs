namespace _8._Traffic_Jam
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int countPassed = 0;
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        countPassed++;
                    }

                    continue;
                }

                queue.Enqueue(input);

            }

            Console.WriteLine($"{countPassed} cars passed the crossroads.");
        }
    }
}
