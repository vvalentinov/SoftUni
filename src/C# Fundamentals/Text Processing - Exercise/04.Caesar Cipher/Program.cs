namespace _04.Caesar_Cipher
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            foreach (char ch in line)
            {
                char currentChar = (char)(ch + 3);
                Console.Write(currentChar);
            }
        }
    }
}
