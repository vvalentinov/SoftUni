namespace _06.Replace_Repeating_Chars
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                }
            }
            char symbol = input[input.Length - 1];
            sb.Append(symbol);
            Console.WriteLine(sb);
        }
    }
}
