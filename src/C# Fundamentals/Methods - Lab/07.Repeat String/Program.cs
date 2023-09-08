namespace _07.Repeat_String
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            StringRepeat(text, count);
        }
        private static void StringRepeat(string text, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= count; i++)
            {
                sb.Append(text);
            }
            Console.WriteLine(sb);
        }
    }
}
