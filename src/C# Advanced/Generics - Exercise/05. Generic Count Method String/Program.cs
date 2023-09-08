namespace _05._Generic_Count_Method_String
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                values.Add(value);
            }
            string comperator = Console.ReadLine();
            Box<string> box = new Box<string>(values);
            int count = box.GetCount(comperator);
            Console.WriteLine(count);
        }
    }
}
