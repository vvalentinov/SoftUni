namespace _08._SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(input[0]))
                {
                    VIP.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                if (VIP.Contains(line))
                {
                    VIP.Remove(line);
                }
                else if (regular.Contains(line))
                {
                    regular.Remove(line);
                }
            }
            int count = VIP.Count + regular.Count;
            Console.WriteLine(count);
            foreach (var item in VIP)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
}
