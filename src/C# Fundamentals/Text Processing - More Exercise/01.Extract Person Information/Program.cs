namespace _01.Extract_Person_Information
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                int startIdxName = text.IndexOf('@');
                int endIdxName = text.IndexOf('|');

                int countName = endIdxName - startIdxName - 1;
                string name = text.Substring(startIdxName + 1, countName);

                int startIdxAge = text.IndexOf('#');
                int endIdxAge = text.IndexOf('*');
                int countAge = endIdxAge - startIdxAge - 1;
                string age = text.Substring(startIdxAge + 1, countAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
