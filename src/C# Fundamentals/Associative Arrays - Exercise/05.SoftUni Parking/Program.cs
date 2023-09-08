namespace _05.SoftUni_Parking
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 1; i <= n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string command = line[0];
                string userName = line[1];
                if (command == "register")
                {
                    string plateNumber = line[2];
                    if (!users.ContainsKey(userName))
                    {
                        users.Add(userName, plateNumber);
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        users.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
