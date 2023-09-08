namespace _02.Repeat_Strings
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string result = string.Empty;
            foreach (var item in arr)
            {
                for (int i = 1; i <= item.Length; i++)
                {
                    result += item;
                }
            }
            Console.WriteLine(result);
        }
    }
}
