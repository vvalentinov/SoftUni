namespace _03.House_Party
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                if (cmdArg.Length > 3)
                {
                    if (guests.Contains(cmdArg[0]))
                    {
                        guests.Remove(cmdArg[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{cmdArg[0]} is not in the list!");
                    }
                }
                else
                {
                    if (!guests.Contains(cmdArg[0]))
                    {
                        guests.Add(cmdArg[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{cmdArg[0]} is already in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
