namespace _04.Reverse_String
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                builder.Append(input[i]);
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
