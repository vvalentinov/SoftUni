namespace _05.Decrypting_Message
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string sumMessage = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int value = symbol + key;
                char letter = (char)value;
                sumMessage += letter;
            }
            Console.WriteLine(sumMessage);
        }
    }
}
